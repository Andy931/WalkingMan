namespace WalkingMan
{
    partial class frmWalkingMan
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
            this.btnWalkingMan = new System.Windows.Forms.Button();
            this.picMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalkingMan
            // 
            this.btnWalkingMan.Location = new System.Drawing.Point(197, 226);
            this.btnWalkingMan.Name = "btnWalkingMan";
            this.btnWalkingMan.Size = new System.Drawing.Size(75, 23);
            this.btnWalkingMan.TabIndex = 0;
            this.btnWalkingMan.Text = "Play";
            this.btnWalkingMan.UseVisualStyleBackColor = true;
            this.btnWalkingMan.Click += new System.EventHandler(this.btnWalkingMan_Click);
            // 
            // picMan
            // 
            this.picMan.Location = new System.Drawing.Point(40, 30);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(100, 50);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMan.TabIndex = 1;
            this.picMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.btnWalkingMan);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWalkingMan;
        private System.Windows.Forms.PictureBox picMan;
    }
}

