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
            this.SuspendLayout();
            // 
            // labelProcessPath
            // 
            this.labelProcessPath.AutoSize = true;
            this.labelProcessPath.Location = new System.Drawing.Point(12, 33);
            this.labelProcessPath.Name = "labelProcessPath";
            this.labelProcessPath.Size = new System.Drawing.Size(75, 12);
            this.labelProcessPath.TabIndex = 2;
            this.labelProcessPath.Text = "起動するアプリ:";
            // 
            // buttonProcessPathReference
            // 
            this.buttonProcessPathReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcessPathReference.Location = new System.Drawing.Point(552, 59);
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
            this.textProcessPath.Location = new System.Drawing.Point(34, 61);
            this.textProcessPath.Name = "textProcessPath";
            this.textProcessPath.Size = new System.Drawing.Size(512, 19);
            this.textProcessPath.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(444, 144);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // CANCEL
            // 
            this.CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL.Location = new System.Drawing.Point(525, 144);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 179);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textProcessPath);
            this.Controls.Add(this.buttonProcessPathReference);
            this.Controls.Add(this.labelProcessPath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "オプション";
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
    }
}