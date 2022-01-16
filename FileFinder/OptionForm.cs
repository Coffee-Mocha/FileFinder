using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();

            this.CANCEL.Click += CANCEL_Click;
            this.OK.Click += OK_Click;
            this.buttonProcessPathReference.Click += ButtonProcessPathReference_Click;

            this.textProcessPath.Text = Settings.Default.ExternalAppPath;
        }

        private void ButtonProcessPathReference_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            //ダイアログのタイトルを指定する
            this.openFileDialogProcPath.Title = "起動するアプリの選択";

            // デフォルトのフォルダを指定する
            //openFileDialogProcPath.InitialDirectory = @"C:\Program Files\Microsoft Office\root\Office16";
            // ディレクトリパス
            string externalAppPath = Settings.Default.ExternalAppPath;

            // ダイアログの初期選択ファイルを指定する
            if (!string.IsNullOrEmpty(externalAppPath))
            {
                // FileInfoのインスタンスを生成する
                FileInfo fileInfo = new FileInfo(externalAppPath);
                if (fileInfo.Exists)
                {
                    openFileDialogProcPath.FileName = Path.GetFileName(externalAppPath);
                }

                // フォルダー名（ディレクトリ名）を取得する
                string externalAppDirectory = fileInfo.DirectoryName;
                if (Directory.Exists(externalAppDirectory))
                {
                    openFileDialogProcPath.InitialDirectory = externalAppDirectory;
                }

                //openFileDialogProcPath.FileName = @"EXCEL.EXE";
            }

            //ダイアログを表示する
            if (openFileDialogProcPath.ShowDialog() == DialogResult.OK)
            {
                textProcessPath.Text = openFileDialogProcPath.FileName;
            }
            else
            {
                Console.WriteLine("キャンセルされました");
            }

            // オブジェクトを破棄する
            openFileDialogProcPath.Dispose();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            Settings.Default.ExternalAppPath = this.textProcessPath.Text;
            Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
