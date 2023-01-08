namespace FileFinder
{
    partial class FilePropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePropertyForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.textDirectoryName = new System.Windows.Forms.TextBox();
            this.labelDirectoryName = new System.Windows.Forms.Label();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textLastWriteTime = new System.Windows.Forms.TextBox();
            this.labelLastWriteTime = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelCreationTime = new System.Windows.Forms.Label();
            this.textCreationTime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.54321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.45679F));
            this.tableLayoutPanel1.Controls.Add(this.OK, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textFileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textDirectoryName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDirectoryName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textExtension, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelExtension, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textLastWriteTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelLastWriteTime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxIcon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCreationTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textCreationTime, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.75904F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.24096F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OK.Location = new System.Drawing.Point(246, 322);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "閉じる";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // textFileName
            // 
            this.textFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textFileName.Location = new System.Drawing.Point(89, 3);
            this.textFileName.Multiline = true;
            this.textFileName.Name = "textFileName";
            this.textFileName.ReadOnly = true;
            this.textFileName.Size = new System.Drawing.Size(232, 64);
            this.textFileName.TabIndex = 0;
            this.textFileName.Text = "ファイル名";
            // 
            // textDirectoryName
            // 
            this.textDirectoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDirectoryName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textDirectoryName.Location = new System.Drawing.Point(89, 106);
            this.textDirectoryName.Multiline = true;
            this.textDirectoryName.Name = "textDirectoryName";
            this.textDirectoryName.ReadOnly = true;
            this.textDirectoryName.Size = new System.Drawing.Size(232, 44);
            this.textDirectoryName.TabIndex = 1;
            this.textDirectoryName.Text = "場所";
            // 
            // labelDirectoryName
            // 
            this.labelDirectoryName.AutoSize = true;
            this.labelDirectoryName.Location = new System.Drawing.Point(3, 103);
            this.labelDirectoryName.Name = "labelDirectoryName";
            this.labelDirectoryName.Size = new System.Drawing.Size(31, 12);
            this.labelDirectoryName.TabIndex = 2;
            this.labelDirectoryName.Text = "場所:";
            // 
            // textExtension
            // 
            this.textExtension.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textExtension.Location = new System.Drawing.Point(89, 73);
            this.textExtension.Name = "textExtension";
            this.textExtension.ReadOnly = true;
            this.textExtension.Size = new System.Drawing.Size(232, 12);
            this.textExtension.TabIndex = 3;
            this.textExtension.Text = "ファイルの種類";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(3, 70);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(75, 12);
            this.labelExtension.TabIndex = 4;
            this.labelExtension.Text = "ファイルの種類:";
            // 
            // textLastWriteTime
            // 
            this.textLastWriteTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLastWriteTime.Location = new System.Drawing.Point(89, 178);
            this.textLastWriteTime.Name = "textLastWriteTime";
            this.textLastWriteTime.ReadOnly = true;
            this.textLastWriteTime.Size = new System.Drawing.Size(232, 12);
            this.textLastWriteTime.TabIndex = 5;
            this.textLastWriteTime.Text = "更新日時";
            this.textLastWriteTime.WordWrap = false;
            // 
            // labelLastWriteTime
            // 
            this.labelLastWriteTime.AutoSize = true;
            this.labelLastWriteTime.Location = new System.Drawing.Point(3, 175);
            this.labelLastWriteTime.Name = "labelLastWriteTime";
            this.labelLastWriteTime.Size = new System.Drawing.Size(55, 12);
            this.labelLastWriteTime.TabIndex = 6;
            this.labelLastWriteTime.Text = "更新日時:";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(80, 64);
            this.pictureBoxIcon.TabIndex = 7;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelCreationTime
            // 
            this.labelCreationTime.AutoSize = true;
            this.labelCreationTime.Location = new System.Drawing.Point(3, 153);
            this.labelCreationTime.Name = "labelCreationTime";
            this.labelCreationTime.Size = new System.Drawing.Size(55, 12);
            this.labelCreationTime.TabIndex = 8;
            this.labelCreationTime.Text = "作成日時:";
            // 
            // textCreationTime
            // 
            this.textCreationTime.BackColor = System.Drawing.SystemColors.Control;
            this.textCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCreationTime.Location = new System.Drawing.Point(89, 156);
            this.textCreationTime.Name = "textCreationTime";
            this.textCreationTime.ReadOnly = true;
            this.textCreationTime.Size = new System.Drawing.Size(232, 12);
            this.textCreationTime.TabIndex = 9;
            this.textCreationTime.Text = "作成日時";
            this.textCreationTime.WordWrap = false;
            // 
            // FilePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilePropertyForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FilePropertyForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox textDirectoryName;
        private System.Windows.Forms.Label labelDirectoryName;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textLastWriteTime;
        private System.Windows.Forms.Label labelLastWriteTime;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelCreationTime;
        private System.Windows.Forms.TextBox textCreationTime;
    }
}