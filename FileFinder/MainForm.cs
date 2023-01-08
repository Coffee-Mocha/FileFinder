using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace FileFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;

            // メニュー項目のイベントハンドラ
            this.exitXToolStripMenuItem.Click += ExitXToolStripMenuItem_Click;
            this.editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            this.openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            this.copypathToolStripMenuItem.Click += CopypathToolStripMenuItem_Click;
            this.OptionOToolStripMenuItem.Click += OptionOToolStripMenuItem_Click;
            this.aboutAToolStripMenuItem.Click += AboutAToolStripMenuItem_Click;

            // テキストボックスが変更されたときのイベントハンドラ
            this.textFindBase.TextChanged += TextFindBase_TextChanged;
            this.textFind.TextChanged += TextFind_TextChanged;

            // リストビューのイベントハンドラ
            this.listFiles.MouseDoubleClick += ListFiles_MouseDoubleClick;
            this.listFiles.MouseClick += ListFiles_MouseClick;

            // ボタンが押されたときにイベントハンドラ
            this.buttonBrowse.Click += ButtonBrowse_Click;
            this.buttonFind.Click += ButtonFind_Click;
            this.buttonListUpdate.Click += ButtonListUpdate_Click;
            this.buttonFindReset.Click += ButtonFindReset_Click;

            // コンテキストメニューのイベントハンドラ
            this.openToolStripContextMenuItem.Click += OpenToolStripMenuItem_Click;
            this.copypathToolStripContextMenuItem.Click += CopypathToolStripMenuItem_Click;
            this.propertyToolStripContextMenuItem.Click += PropertyToolStripMenuItem_Click;

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // メニュー項目「開く」の状態設定
            if (this.listFiles.SelectedItems.Count > 0)
            {
                // リスト項目が選択されていれば有効化
                this.openToolStripMenuItem.Enabled = true;
                // ファイルのアイコン
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    Icon appIcon = System.Drawing.Icon.ExtractAssociatedIcon(item.Text);
                    this.openToolStripMenuItem.Image = appIcon.ToBitmap();
                }
            }
            else
            {
                // リスト項目が選択されていなければ無効化
                this.openToolStripMenuItem.Enabled = false;
            }

            // メニュー項目「パスのコピー」の状態設定
            if (this.listFiles.SelectedItems.Count > 0)
            {
                // リスト項目が選択されていれば有効化
                this.copypathToolStripMenuItem.Enabled = true;
            }
            else
            {
                // リスト項目が選択されていなければ無効化
                this.copypathToolStripMenuItem.Enabled = false;
            }
        }

        private void ButtonFindReset_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.textFind.Text = "";

            // リストビューを更新
            RefreshListFiles();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();

            if (Directory.Exists(this.textFindBase.Text))
            {
                Settings.Default.FindBase = (this.textFindBase.Text).TrimEnd(Path.DirectorySeparatorChar);
                Settings.Default.Save();
            }
        }

        private void ButtonListUpdate_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // リストビューを更新
            RefreshListFiles();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // リストビューの更新(初期化と一覧作成)
            InitializeListFiles();

            // フォームにコンテキストメニューを登録
            //this.ContextMenuStrip = this.contextMenuStripListFile;

            // 設定の読み込み
            //this.textFindBase.Text = Settings.Default.FindBase;
            this.textFindBase.Text = GetSettingsFindBase();
            this.checkNewProcess.Checked = Settings.Default.CmdSwitchInstanceExecute;
            this.checkReadOnly.Checked = Settings.Default.CmdSwitchReadOnly;

        }

        private void ListFiles_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();

            if (e.Button == MouseButtons.Right)
            {
                //コンテキストメニューを表示する座標
                //System.Drawing.Point p = new System.Drawing.Point(50, 10);
                //this.contextMenuStripListFile.Show(this.listFiles, p);

                //フォーム上の座標でマウスポインタの位置を取得する
                //画面座標でマウスポインタの位置を取得する
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                //画面座標をクライアント座標に変換する
                //System.Drawing.Point cp = this.PointToClient(sp);
                //this.contextMenuStripListFile.Show(sp);

                if (this.listFiles.SelectedItems.Count > 0)
                {
                    this.contextMenuStripListFile.Show(sp);
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.listFiles.SelectedItems.Count > 0)
            {
                /*
                // リストビューで選択されている項目
                ListViewItem itemx = new ListViewItem();
                itemx = this.listFiles.SelectedItems[0];
                */

                // リストビューで選択されている項目
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    ExecApp(item.Text);
                }
            }
        }

        private void CopypathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // リストビューで選択されている項目
            foreach (ListViewItem item in this.listFiles.SelectedItems)
            {
                // パスをクリップボードにコピー
                // Clipboard.SetText(item.Text);
                // Clipboard.SetDataObject(item.Text);
                DataObject data = new DataObject();
                data.SetData(item.Text);
                Clipboard.SetDataObject(data, true);
            }
        }

        private void PropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.listFiles.SelectedItems.Count > 0)
            {
                // リストビューで選択されている項目
                foreach (ListViewItem item in listFiles.SelectedItems)
                {
                    // ファイルのプロパティフォームを表示
                    FilePropertyForm formProperty = new FilePropertyForm
                    {
                        FileName = item.Text
                    };
                    //formProperty.Show();

                    //フォーム上の座標でマウスポインタの位置を取得する
                    //画面座標でマウスポインタの位置を取得する
                    System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                    //画面座標をクライアント座標に変換する
                    //System.Drawing.Point cp = this.PointToClient(sp);
                    formProperty.location = sp;
                    formProperty.Show();
                }
            }
        }

        private void AboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // バージョン情報フォームを表示
            AboutBox formAbout = new AboutBox();
            formAbout.ShowDialog();
        }

        private void TextFind_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // 検索ボタンの表示／非表示
            if (this.textFind.TextLength == 0)
            {
                // 検索ボックスが空
                this.buttonFind.Visible = false;     // 検索ボタンを非表示
            }
            else
            {
                // 検索ボックスに文字が入力された
                this.buttonFind.Visible = true;     // 検索ボタンを表示
                this.buttonFindReset.Visible = false;   // リセットボタンを非表示
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // リストビューを更新
            RefreshListFiles();

            this.buttonFindReset.Visible = true;    // リセットボタンを表示
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // フォルダ選択ダイアログの表示
            this.folderBrowserDialog.SelectedPath = GetSettingsFindBase();
            this.folderBrowserDialog.ShowNewFolderButton = false;

            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // OK: 検索フォルダのパスを設定
                this.textFindBase.Text = this.folderBrowserDialog.SelectedPath.ToString();
            }
        }

        private void ListFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();

            if (this.listFiles.SelectedItems.Count > 0)
            {
                /*
                // リストビューで選択されている項目
                ListViewItem itemx = new ListViewItem();
                itemx = this.listFiles.SelectedItems[0];
                */

                // リストビューで選択されている項目
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    if (item.Text != null)
                    {
                        ExecApp(item.Text);
                    }
                }
            }
        }

        private void TextFindBase_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (Directory.Exists(this.textFindBase.Text))
            {
                //Settings.Default.FindBase = (this.textFindBase.Text).TrimEnd(Path.DirectorySeparatorChar);
                //Settings.Default.Save();

                // [更新]ボタンを表示
                this.buttonListUpdate.Visible = true;
            }
            else
            {
                // [更新]ボタンを非表示
                this.buttonListUpdate.Visible = false;
            }

            /*
            // リストビューを更新
            RefreshListFiles();
            */
        }

        private void OptionOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // オプションフォームを表示
            OptionForm formOption = new OptionForm();
            formOption.ShowDialog();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.Close();
        }

        // ListViewコントロールを初期化します。
        private void InitializeListFiles()
        {
            // ListViewコントロールのプロパティを設定
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.Sorting = SortOrder.Ascending;
            this.listFiles.View = View.Details;

            // ヘッダの作成
            ColumnHeader columnFile = new ColumnHeader
            {
                Text = "ファイル",
                Width = 0
            };
            ColumnHeader columnName = new ColumnHeader
            {
                Text = "名前",
                Width = 600
            };
            ColumnHeader columnType = new ColumnHeader
            {
                Text = "更新日時",
                Width = 120
            };
            ColumnHeader[] colHeaderRegValue =
              { columnFile, columnName, columnType };
            this.listFiles.Columns.AddRange(colHeaderRegValue);
        }

        // ListViewコントロールのデータを更新します。
        private void RefreshListFiles()
        {
            this.buttonFindReset.Visible = false;   // リセットボタンを非表示

            // ListViewコントロールのデータをすべて消去します。
            this.listFiles.Items.Clear();

            string searchRoot = (this.textFindBase.Text).TrimEnd(Path.DirectorySeparatorChar);
            string findText = "*" + this.textFind.Text + "*.xl*";

            if (Directory.Exists(searchRoot))
            {
                try
                {
                    IEnumerable<string> files = Directory.EnumerateFiles(
                        searchRoot,                   // 検索開始ディレクトリ
                        findText,                     // 検索パターン
                        SearchOption.AllDirectories   // サブ・ディレクトも含める
                    );

                    foreach (string file in files)
                    {
                        string fileName = file.Substring(searchRoot.Length + 1);

                        DateTime dt = Directory.GetLastWriteTime(file);

                        //Console.WriteLine(file);
                        string[] item1 = {
                            file,
                            fileName,
                            dt.ToString()
                        };
                        this.listFiles.Items.Add(new ListViewItem(item1));
                    }
                }
                catch (ArgumentException e)
                {
                    string message = e.Message;

                    char[] invalidPathChars = Path.GetInvalidPathChars();
                    if (invalidPathChars.Length > 0)
                    {
                        message += Environment.NewLine + invalidPathChars.ToString();
                    }
                    else
                    {
                        message += Environment.NewLine + "検索パターンを確認してください。";
                    }
                    string caption = "ArgumentException Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (SecurityException e)
                {
                    string message = e.Message;
                    string caption = "SecurityException Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (UnauthorizedAccessException uAEx)
                {
                    string message = uAEx.Message;
                    string caption = "UnauthorizedAccessException Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ExecApp(string filepath)
        {
            // ファイルの開き方のチェック状態
            bool newprocess = this.checkNewProcess.Checked;     // 新しいプロセスで起動
            bool ro = this.checkReadOnly.Checked;         // 読み取り専用で開く

            ProcessStartInfo pInfo = new ProcessStartInfo();

            string openfile = filepath;
            if (newprocess || ro)
            {
                // アプリを起動して、対象のファイルを開く

                // ファイルのパスが260文字を超えているとき
                if (filepath.Length >= 260)
                {
                    string message = "ファイルのパスが260文字を超えています。";
                    message += Environment.NewLine;
                    message += Environment.NewLine + "ファイルのコピーを開きます。";
                    string caption = "ファイルを開く";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);

                    openfile = CopyTemporaryFile(@"\\?\" + filepath);
                }

                // 起動するアプリ
                pInfo.FileName = Settings.Default.ExternalAppPath;

                // コマンドオプションの指定
                string cmdswitch = "";
                if (newprocess)
                {
                    cmdswitch += Settings.Default.CmdSwitchInstanceExecuteText + " ";
                }
                if (ro)
                {
                    cmdswitch += Settings.Default.CmdSwitchReadOnlyText + " ";
                }

                //pInfo.Arguments = "/x /r \"" + itemx.Text + "\"";
                // pInfo.Arguments = "/x /r \"" + openfile + "\"";
                pInfo.Arguments = cmdswitch + "\"" + openfile + "\"";
            }
            else
            {
                // ファイルの関連付けで開く
                pInfo.UseShellExecute = true;
                pInfo.ErrorDialog = true;
                pInfo.FileName = openfile;
            }

            // プロセスの実行
            using (Process process = new Process())
            {
                try
                {
                    process.StartInfo = pInfo;
                    process.Start();
                }
                catch (PlatformNotSupportedException ex)   // 関連付けが見つからない
                {
                    //Console.WriteLine(ex.Message);

                    string message = ex.Message + Environment.NewLine + openfile;
                    string caption = "PlatformNotSupportedException Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (Win32Exception ex)   // 指定したファイルが見つからない
                {
                    //Console.WriteLine(ex.Message);

                    string message = ex.Message + Environment.NewLine + openfile;
                    string caption = "Win32Exception Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    string message = ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        private string GetSettingsFindBase()
        {
            string findbase = Settings.Default.FindBase;
            if ((findbase == null) | !(Directory.Exists(findbase)))
            {
                findbase = Path.GetDirectoryName(Application.ExecutablePath);
            }

            return findbase;
        }

        // 一時ファイルへのコピー
        private string CopyTemporaryFile(string fileName)
        {
            FileInfo sourcefile = new FileInfo(fileName);
            //DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            string destname = di.FullName + @"\~" + sourcefile.Name;

            try
            {
                sourcefile.CopyTo(destname, true);
            }
            /*
            catch (IOException e)   // エラーが発生したか、リンク先ファイルが既に存在します。
            {

            }
            catch (PathTooLongException e)  // 指定したパス、ファイル名、またはその両方がシステム定義の最大長を超えています。
            {

            }
            */
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                destname = null;
            }

            return destname;
        }
    }
}
