namespace FileFinder
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textFind = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textFindBase = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkNewProcess = new System.Windows.Forms.CheckBox();
            this.checkReadOnly = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripListFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFind
            // 
            this.textFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFind.Location = new System.Drawing.Point(558, 46);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(138, 12);
            this.textFind.TabIndex = 3;
            this.toolTip.SetToolTip(this.textFind, "ファイルを検索する文字を入力します。");
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(12, 82);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(719, 210);
            this.listFiles.TabIndex = 5;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(497, 41);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(47, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "参照...";
            this.toolTip.SetToolTip(this.buttonBrowse, "検索するフォルダを参照するダイアログを表示します。");
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // textFindBase
            // 
            this.textFindBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFindBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFindBase.Location = new System.Drawing.Point(12, 46);
            this.textFindBase.Name = "textFindBase";
            this.textFindBase.Size = new System.Drawing.Size(479, 12);
            this.textFindBase.TabIndex = 1;
            this.toolTip.SetToolTip(this.textFindBase, "検索するフォルダをフルパスで入力します。");
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(702, 41);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(29, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "▶";
            this.toolTip.SetToolTip(this.buttonFind, "ファイルの検索を開始します。");
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.toolsTToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(743, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitXToolStripMenuItem.Text = "終了(&X)";
            // 
            // toolsTToolStripMenuItem
            // 
            this.toolsTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionOToolStripMenuItem});
            this.toolsTToolStripMenuItem.Name = "toolsTToolStripMenuItem";
            this.toolsTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.toolsTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // OptionOToolStripMenuItem
            // 
            this.OptionOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OptionOToolStripMenuItem.Image")));
            this.OptionOToolStripMenuItem.Name = "OptionOToolStripMenuItem";
            this.OptionOToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.OptionOToolStripMenuItem.Text = "オプション(&O)...";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutAToolStripMenuItem.Text = "バージョン情報(&A)...";
            // 
            // contextMenuStripListFile
            // 
            this.contextMenuStripListFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.propertyToolStripMenuItem});
            this.contextMenuStripListFile.Name = "contextMenuStripListFile";
            this.contextMenuStripListFile.Size = new System.Drawing.Size(134, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "開く(&O)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.propertyToolStripMenuItem.Text = "プロパティ(&R)";
            // 
            // checkNewProcess
            // 
            this.checkNewProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNewProcess.AutoSize = true;
            this.checkNewProcess.Location = new System.Drawing.Point(611, 301);
            this.checkNewProcess.Name = "checkNewProcess";
            this.checkNewProcess.Size = new System.Drawing.Size(120, 16);
            this.checkNewProcess.TabIndex = 6;
            this.checkNewProcess.Text = "新しいプロセスで開く";
            this.checkNewProcess.UseVisualStyleBackColor = true;
            // 
            // checkReadOnly
            // 
            this.checkReadOnly.AutoSize = true;
            this.checkReadOnly.Location = new System.Drawing.Point(465, 301);
            this.checkReadOnly.Name = "checkReadOnly";
            this.checkReadOnly.Size = new System.Drawing.Size(119, 16);
            this.checkReadOnly.TabIndex = 7;
            this.checkReadOnly.Text = "読み取り専用で開く";
            this.checkReadOnly.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 329);
            this.Controls.Add(this.checkReadOnly);
            this.Controls.Add(this.checkNewProcess);
            this.Controls.Add(this.textFindBase);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "XLSOpener";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripListFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textFindBase;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkNewProcess;
        private System.Windows.Forms.CheckBox checkReadOnly;
    }
}

