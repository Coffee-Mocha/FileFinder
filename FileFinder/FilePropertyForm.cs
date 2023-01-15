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
    public partial class FilePropertyForm : Form
    {
        public string FileName
        { get; set; }

        public System.Drawing.Point location
        { get; set; }

        public FilePropertyForm()
        {
            InitializeComponent();

            this.Load += FilePropertyForm_Load;

            this.OK.Click += OK_Click;
        }

        private void FilePropertyForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // ファイルの情報
            FileInfo fi = new FileInfo(FileName);

            this.Text = fi.Name.Replace(fi.Extension, "") + "のプロパティ";   // フォームのタイトル
            this.Location = location;

            // ファイルのアイコン
            try
            {
                Icon appIcon = System.Drawing.Icon.ExtractAssociatedIcon(FileName);
                pictureBoxIcon.Image = appIcon.ToBitmap();
            }
            catch (System.IO.PathTooLongException ex)
            {
                // パス名またはファイル名がシステム定義の最大長よりも長いときにスローされる例外。
                string msg = ex.Message + Environment.NewLine + "パス名またはファイル名がシステム定義の最大長よりも長い";
                MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // ディスク上に存在しないファイルにアクセスしようとして失敗したときにスローされる例外。
                //string msg = ex.FileName + Environment.NewLine + ex.Message + Environment.NewLine + ex.TargetSite + Environment.NewLine + ex.GetType().Name + Environment.NewLine + "FileNotFoundException ファイルの情報を取得できません。";
                string msg = ex.FileName + Environment.NewLine + ex.Message + Environment.NewLine + "ファイルの情報を取得できません。";
                MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                //
                //string msg = ex.Message + Environment.NewLine + "ファイルの情報を取得できません。";
                string msg = ex.Message + Environment.NewLine + ex.TargetSite + Environment.NewLine + ex.GetType().Name + Environment.NewLine + "ファイルの情報を取得できません。";
                MessageBox.Show(msg,"エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            textFileName.Text = fi.Name.Replace(fi.Extension, "");      // ファイル名
            textExtension.Text = "(" + fi.Extension + ")";              // 拡張子
            textDirectoryName.Text = fi.DirectoryName;                  // 場所

            // 作成日時
            DateTime dtc = Directory.GetCreationTime(FileName);
            textCreationTime.Text = dtc.ToString();

            // 更新日時
            DateTime dtlw = Directory.GetLastWriteTime(FileName);
            textLastWriteTime.Text = dtlw.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.Close();
        }
    }
}
