using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;

            // メニュー項目のイベントハンドラ
            this.exitXToolStripMenuItem.Click += ExitXToolStripMenuItem_Click;
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

            // コンテキストメニューのイベントハンドラ
            this.openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            this.propertyToolStripMenuItem.Click += PropertyToolStripMenuItem_Click;

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

        private void PropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.listFiles.SelectedItems.Count > 0)
            {
                // リストビューで選択されている項目
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    // ファイルのプロパティフォームを表示
                    FilePropertyForm formeProperty = new FilePropertyForm();
                    formeProperty.FileName = item.Text;
                    //formeProperty.Show();
                    
                    //フォーム上の座標でマウスポインタの位置を取得する
                    //画面座標でマウスポインタの位置を取得する
                    System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                    //画面座標をクライアント座標に変換する
                    //System.Drawing.Point cp = this.PointToClient(sp);
                    formeProperty.location = sp;
                    formeProperty.Show();
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

                ExecExternalApp(itemx.Text);
                */

                // リストビューで選択されている項目
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    ExecExternalApp(item.Text);
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
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // リストビューを更新
            RefreshListFiles();

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

                ExecExternalApp(itemx.Text);
                */

                // リストビューで選択されている項目
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    // ExecExternalApp(item.Text);

                    if (item.Text != null)
                    {
                        if (this.checkNewProcess.Checked || this.checkReadOnly.Checked)
                        {
                            ExecExternalApp(item.Text);
                        }
                        else
                        {
                            ExecDefaultApp(item.Text);
                        }
                    }

                }
            }
        }

        private void TextFindBase_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (Directory.Exists(this.textFindBase.Text))
            {
                Settings.Default.FindBase = (this.textFindBase.Text).TrimEnd(Path.DirectorySeparatorChar);
                Settings.Default.Save();

            }

            // リストビューを更新
            RefreshListFiles();
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ExecExternalApp(string argfile)
        {
            /*
            // リストビューで選択されている項目
            ListViewItem itemx = new ListViewItem();
            itemx = this.listFiles.SelectedItems[0];
            */

            // アプリを起動して、対象のファイルを開く
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = Settings.Default.ExternalAppPath;
            string cmdswitch = "";
            if (this.checkNewProcess.Checked)
            {
                cmdswitch += Settings.Default.CmdSwitchInstanceExecuteText + " ";
            }
            if (this.checkReadOnly.Checked)
            {
                cmdswitch += Settings.Default.CmdSwitchReadOnlyText + " ";
            }

            //pInfo.Arguments = "/x /r \"" + itemx.Text + "\"";
            // pInfo.Arguments = "/x /r \"" + argfile + "\"";
            pInfo.Arguments = cmdswitch + "\"" + argfile + "\"";

            try
            {
                // アプリを起動
                Process.Start(pInfo);
            }
            catch (Win32Exception ex)   // 指定したファイルが見つからない
            {
                //Console.WriteLine(ex.Message);

                string message = ex.Message + Environment.NewLine + pInfo.FileName;
                string caption = "Error";
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

        private void ExecDefaultApp(string filename)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.UseShellExecute = true;
            pInfo.ErrorDialog = true;
            pInfo.FileName = filename;

            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = pInfo;
                    process.Start();
                }
            }
            catch (PlatformNotSupportedException ex)   // 関連付けが見つからない
            {
                //Console.WriteLine(ex.Message);

                string message = ex.Message + Environment.NewLine + filename;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            catch (Win32Exception ex)   // 指定したファイルが見つからない
            {
                //Console.WriteLine(ex.Message);

                string message = ex.Message + Environment.NewLine + filename;
                string caption = "Error";
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

        private string GetSettingsFindBase()
        {
            string findbase = Settings.Default.FindBase;
            if ((findbase == null) | !(Directory.Exists(findbase)))
            {
                findbase = Path.GetDirectoryName(Application.ExecutablePath);
            }

            return findbase;
        }

    }
}
