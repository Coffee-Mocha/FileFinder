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

            this.Load += OptionForm_Load;

            this.CANCEL.Click += CANCEL_Click;
            this.OK.Click += OK_Click;
            this.buttonProcessPathReference.Click += ButtonProcessPathReference_Click;
            this.buttonMicrosoft365ExcelPath.Click += ButtonMicrosoft365ExcelPath_Click;
            this.buttonOffice2016ExcelPath.Click += ButtonOffice2016ExcelPath_Click;
            this.buttonResetCmdSwitchReadOnly.Click += ButtonResetCmdSwitchReadOnly_Click;
            this.buttonResetCmdSwitchInstanceExecute.Click += ButtonResetCmdSwitchInstanceExecute_Click;
        }

        private void ButtonResetCmdSwitchInstanceExecute_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.textCmdSwitchInstanceExecute.Text = Settings.Default.DefaultCmdSwitchInstanceExecuteText;
        }

        private void ButtonResetCmdSwitchReadOnly_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.textCmdSwitchReadOnly.Text = Settings.Default.DefaultCmdSwitchReadOnlyText;
        }

        private void ButtonOffice2016ExcelPath_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.textProcessPath.Text = Settings.Default.StanderdOffice2016ExcelPath;
        }

        private void ButtonMicrosoft365ExcelPath_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.textProcessPath.Text = Settings.Default.StanderdMicrosoft365ExcelPath;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // 設定の読み込み
            this.textProcessPath.Text = Settings.Default.ExternalAppPath;
            this.checkCmdSwitchReadOnly.Checked = Settings.Default.CmdSwitchReadOnly;
            this.checkCmdSwitchInstanceExecute.Checked = Settings.Default.CmdSwitchInstanceExecute;
            this.textCmdSwitchReadOnly.Text = Settings.Default.CmdSwitchReadOnlyText;
            this.textCmdSwitchInstanceExecute.Text = Settings.Default.CmdSwitchInstanceExecuteText;
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

            // 設定の保存
            Settings.Default.ExternalAppPath = this.textProcessPath.Text;
            Settings.Default.CmdSwitchReadOnly = this.checkCmdSwitchReadOnly.Checked;
            Settings.Default.CmdSwitchInstanceExecute = this.checkCmdSwitchInstanceExecute.Checked;
            Settings.Default.CmdSwitchReadOnlyText = this.textCmdSwitchReadOnly.Text;
            Settings.Default.CmdSwitchInstanceExecuteText = this.textCmdSwitchInstanceExecute.Text;

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
