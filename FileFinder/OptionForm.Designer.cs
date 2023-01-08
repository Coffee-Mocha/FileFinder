using System;

namespace FileFinder
{
    partial class OptionForm
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
            this.labelProcessPath = new System.Windows.Forms.Label();
            this.buttonProcessPathReference = new System.Windows.Forms.Button();
            this.textProcessPath = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.openFileDialogProcPath = new System.Windows.Forms.OpenFileDialog();
            this.labelCommandLineSwitch = new System.Windows.Forms.Label();
            this.checkCmdSwitchReadOnly = new System.Windows.Forms.CheckBox();
            this.checkCmdSwitchInstanceExecute = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCmdSwitchReadOnly = new System.Windows.Forms.Label();
            this.labelCmdSwitchInstanceExecute = new System.Windows.Forms.Label();
            this.textCmdSwitchInstanceExecute = new System.Windows.Forms.TextBox();
            this.textCmdSwitchReadOnly = new System.Windows.Forms.TextBox();
            this.buttonResetCmdSwitchReadOnly = new System.Windows.Forms.Button();
            this.buttonResetCmdSwitchInstanceExecute = new System.Windows.Forms.Button();
            this.buttonMicrosoft365ExcelPath = new System.Windows.Forms.Button();
            this.buttonOffice2016ExcelPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProcessPath
            // 
            this.labelProcessPath.AutoSize = true;
            this.labelProcessPath.Location = new System.Drawing.Point(12, 21);
            this.labelProcessPath.Name = "labelProcessPath";
            this.labelProcessPath.Size = new System.Drawing.Size(91, 12);
            this.labelProcessPath.TabIndex = 2;
            this.labelProcessPath.Text = "Excel.exeの場所::";
            // 
            // buttonProcessPathReference
            // 
            this.buttonProcessPathReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcessPathReference.Location = new System.Drawing.Point(543, 46);
            this.buttonProcessPathReference.Name = "buttonProcessPathReference";
            this.buttonProcessPathReference.Size = new System.Drawing.Size(48, 23);
            this.buttonProcessPathReference.TabIndex = 4;
            this.buttonProcessPathReference.Text = "参照...";
            this.buttonProcessPathReference.UseVisualStyleBackColor = true;
            // 
            // textProcessPath
            // 
            this.textProcessPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textProcessPath.Location = new System.Drawing.Point(25, 48);
            this.textProcessPath.Name = "textProcessPath";
            this.textProcessPath.Size = new System.Drawing.Size(512, 19);
            this.textProcessPath.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(444, 246);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // CANCEL
            // 
            this.CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL.Location = new System.Drawing.Point(525, 246);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            // 
            // labelCommandLineSwitch
            // 
            this.labelCommandLineSwitch.AutoSize = true;
            this.labelCommandLineSwitch.Location = new System.Drawing.Point(12, 116);
            this.labelCommandLineSwitch.Name = "labelCommandLineSwitch";
            this.labelCommandLineSwitch.Size = new System.Drawing.Size(185, 12);
            this.labelCommandLineSwitch.TabIndex = 7;
            this.labelCommandLineSwitch.Text = "起動オプション (コマンドライン スイッチ):";
            // 
            // checkCmdSwitchReadOnly
            // 
            this.checkCmdSwitchReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkCmdSwitchReadOnly.AutoSize = true;
            this.checkCmdSwitchReadOnly.Location = new System.Drawing.Point(281, 6);
            this.checkCmdSwitchReadOnly.Name = "checkCmdSwitchReadOnly";
            this.checkCmdSwitchReadOnly.Size = new System.Drawing.Size(130, 16);
            this.checkCmdSwitchReadOnly.TabIndex = 2;
            this.checkCmdSwitchReadOnly.Text = "デフォルトで有効にする";
            this.checkCmdSwitchReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkCmdSwitchInstanceExecute
            // 
            this.checkCmdSwitchInstanceExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkCmdSwitchInstanceExecute.AutoSize = true;
            this.checkCmdSwitchInstanceExecute.Location = new System.Drawing.Point(281, 39);
            this.checkCmdSwitchInstanceExecute.Name = "checkCmdSwitchInstanceExecute";
            this.checkCmdSwitchInstanceExecute.Size = new System.Drawing.Size(130, 16);
            this.checkCmdSwitchInstanceExecute.TabIndex = 6;
            this.checkCmdSwitchInstanceExecute.Text = "デフォルトで有効にする";
            this.checkCmdSwitchInstanceExecute.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.50903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.checkCmdSwitchReadOnly, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkCmdSwitchInstanceExecute, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCmdSwitchReadOnly, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCmdSwitchInstanceExecute, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCmdSwitchInstanceExecute, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCmdSwitchReadOnly, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonResetCmdSwitchReadOnly, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonResetCmdSwitchInstanceExecute, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 67);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // labelCmdSwitchReadOnly
            // 
            this.labelCmdSwitchReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCmdSwitchReadOnly.AutoSize = true;
            this.labelCmdSwitchReadOnly.Location = new System.Drawing.Point(3, 8);
            this.labelCmdSwitchReadOnly.Name = "labelCmdSwitchReadOnly";
            this.labelCmdSwitchReadOnly.Size = new System.Drawing.Size(72, 12);
            this.labelCmdSwitchReadOnly.TabIndex = 0;
            this.labelCmdSwitchReadOnly.Text = "読み取り専用";
            // 
            // labelCmdSwitchInstanceExecute
            // 
            this.labelCmdSwitchInstanceExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCmdSwitchInstanceExecute.AutoSize = true;
            this.labelCmdSwitchInstanceExecute.Location = new System.Drawing.Point(3, 41);
            this.labelCmdSwitchInstanceExecute.Name = "labelCmdSwitchInstanceExecute";
            this.labelCmdSwitchInstanceExecute.Size = new System.Drawing.Size(197, 12);
            this.labelCmdSwitchInstanceExecute.TabIndex = 4;
            this.labelCmdSwitchInstanceExecute.Text = "新しいインスタンスを (別プロセスで) 起動";
            // 
            // textCmdSwitchInstanceExecute
            // 
            this.textCmdSwitchInstanceExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textCmdSwitchInstanceExecute.Location = new System.Drawing.Point(223, 38);
            this.textCmdSwitchInstanceExecute.Name = "textCmdSwitchInstanceExecute";
            this.textCmdSwitchInstanceExecute.Size = new System.Drawing.Size(47, 19);
            this.textCmdSwitchInstanceExecute.TabIndex = 5;
            // 
            // textCmdSwitchReadOnly
            // 
            this.textCmdSwitchReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textCmdSwitchReadOnly.Location = new System.Drawing.Point(223, 4);
            this.textCmdSwitchReadOnly.Name = "textCmdSwitchReadOnly";
            this.textCmdSwitchReadOnly.Size = new System.Drawing.Size(47, 19);
            this.textCmdSwitchReadOnly.TabIndex = 1;
            // 
            // buttonResetCmdSwitchReadOnly
            // 
            this.buttonResetCmdSwitchReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonResetCmdSwitchReadOnly.AutoSize = true;
            this.buttonResetCmdSwitchReadOnly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResetCmdSwitchReadOnly.Location = new System.Drawing.Point(501, 3);
            this.buttonResetCmdSwitchReadOnly.Name = "buttonResetCmdSwitchReadOnly";
            this.buttonResetCmdSwitchReadOnly.Size = new System.Drawing.Size(47, 22);
            this.buttonResetCmdSwitchReadOnly.TabIndex = 3;
            this.buttonResetCmdSwitchReadOnly.Text = "リセット";
            this.buttonResetCmdSwitchReadOnly.UseVisualStyleBackColor = true;
            // 
            // buttonResetCmdSwitchInstanceExecute
            // 
            this.buttonResetCmdSwitchInstanceExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonResetCmdSwitchInstanceExecute.AutoSize = true;
            this.buttonResetCmdSwitchInstanceExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResetCmdSwitchInstanceExecute.Location = new System.Drawing.Point(501, 36);
            this.buttonResetCmdSwitchInstanceExecute.Name = "buttonResetCmdSwitchInstanceExecute";
            this.buttonResetCmdSwitchInstanceExecute.Size = new System.Drawing.Size(47, 22);
            this.buttonResetCmdSwitchInstanceExecute.TabIndex = 7;
            this.buttonResetCmdSwitchInstanceExecute.Text = "リセット";
            this.buttonResetCmdSwitchInstanceExecute.UseVisualStyleBackColor = true;
            // 
            // buttonMicrosoft365ExcelPath
            // 
            this.buttonMicrosoft365ExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMicrosoft365ExcelPath.Location = new System.Drawing.Point(358, 73);
            this.buttonMicrosoft365ExcelPath.Name = "buttonMicrosoft365ExcelPath";
            this.buttonMicrosoft365ExcelPath.Size = new System.Drawing.Size(88, 23);
            this.buttonMicrosoft365ExcelPath.TabIndex = 5;
            this.buttonMicrosoft365ExcelPath.Text = "Microsoft365";
            this.buttonMicrosoft365ExcelPath.UseVisualStyleBackColor = true;
            // 
            // buttonOffice2016ExcelPath
            // 
            this.buttonOffice2016ExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOffice2016ExcelPath.Location = new System.Drawing.Point(450, 73);
            this.buttonOffice2016ExcelPath.Name = "buttonOffice2016ExcelPath";
            this.buttonOffice2016ExcelPath.Size = new System.Drawing.Size(88, 23);
            this.buttonOffice2016ExcelPath.TabIndex = 6;
            this.buttonOffice2016ExcelPath.Text = "Office2016";
            this.buttonOffice2016ExcelPath.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 281);
            this.Controls.Add(this.buttonOffice2016ExcelPath);
            this.Controls.Add(this.buttonMicrosoft365ExcelPath);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelCommandLineSwitch);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textProcessPath);
            this.Controls.Add(this.buttonProcessPathReference);
            this.Controls.Add(this.labelProcessPath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "オプション";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcessPath;
        private System.Windows.Forms.Button buttonProcessPathReference;
        private System.Windows.Forms.TextBox textProcessPath;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.OpenFileDialog openFileDialogProcPath;
        private System.Windows.Forms.Label labelCommandLineSwitch;
        private System.Windows.Forms.CheckBox checkCmdSwitchReadOnly;
        private System.Windows.Forms.CheckBox checkCmdSwitchInstanceExecute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCmdSwitchReadOnly;
        private System.Windows.Forms.Label labelCmdSwitchInstanceExecute;
        private System.Windows.Forms.TextBox textCmdSwitchInstanceExecute;
        private System.Windows.Forms.TextBox textCmdSwitchReadOnly;
        private System.Windows.Forms.Button buttonMicrosoft365ExcelPath;
        private System.Windows.Forms.Button buttonOffice2016ExcelPath;
        private System.Windows.Forms.Button buttonResetCmdSwitchReadOnly;
        private System.Windows.Forms.Button buttonResetCmdSwitchInstanceExecute;
    }
}