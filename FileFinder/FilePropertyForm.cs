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
            Icon appIcon =  System.Drawing.Icon.ExtractAssociatedIcon(FileName);
            pictureBoxIcon.Image = appIcon.ToBitmap();

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
