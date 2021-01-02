
namespace AtCad
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelLoadBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(13)))), ((int)(((byte)(9)))));
            this.panelBar.Controls.Add(this.panelLoadBar);
            this.panelBar.Location = new System.Drawing.Point(101, 424);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(726, 27);
            this.panelBar.TabIndex = 0;
            // 
            // panelLoadBar
            // 
            this.panelLoadBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.panelLoadBar.Location = new System.Drawing.Point(0, 0);
            this.panelLoadBar.Name = "panelLoadBar";
            this.panelLoadBar.Size = new System.Drawing.Size(91, 27);
            this.panelLoadBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "AtCad";
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 10;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelLoadBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}