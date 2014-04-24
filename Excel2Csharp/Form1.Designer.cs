namespace Excel2Csharp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathfile = new System.Windows.Forms.TextBox();
            this.bttnbrw = new System.Windows.Forms.Button();
            this.bttnShow = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.displayED = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pathfile
            // 
            this.pathfile.Location = new System.Drawing.Point(94, 29);
            this.pathfile.Multiline = true;
            this.pathfile.Name = "pathfile";
            this.pathfile.Size = new System.Drawing.Size(344, 20);
            this.pathfile.TabIndex = 0;
            // 
            // bttnbrw
            // 
            this.bttnbrw.Location = new System.Drawing.Point(456, 23);
            this.bttnbrw.Name = "bttnbrw";
            this.bttnbrw.Size = new System.Drawing.Size(100, 30);
            this.bttnbrw.TabIndex = 5;
            this.bttnbrw.Text = "Browse";
            this.bttnbrw.UseVisualStyleBackColor = true;
            this.bttnbrw.Click += new System.EventHandler(this.bttnbrw_Click);
            // 
            // bttnShow
            // 
            this.bttnShow.Location = new System.Drawing.Point(456, 82);
            this.bttnShow.Name = "bttnShow";
            this.bttnShow.Size = new System.Drawing.Size(100, 30);
            this.bttnShow.TabIndex = 6;
            this.bttnShow.Text = "Show Data";
            this.bttnShow.UseVisualStyleBackColor = true;
            this.bttnShow.Click += new System.EventHandler(this.bttnShow_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(456, 121);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(100, 30);
            this.bttnReset.TabIndex = 8;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // displayED
            // 
            this.displayED.Location = new System.Drawing.Point(94, 84);
            this.displayED.Multiline = true;
            this.displayED.Name = "displayED";
            this.displayED.Size = new System.Drawing.Size(344, 230);
            this.displayED.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(603, 387);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.displayED);
            this.Controls.Add(this.bttnShow);
            this.Controls.Add(this.bttnbrw);
            this.Controls.Add(this.pathfile);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ERD Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathfile;
        private System.Windows.Forms.Button bttnbrw;
        private System.Windows.Forms.Button bttnShow;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.TextBox displayED;

    }
}

