
namespace AtCad
{
    partial class ucClients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelListbox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelListbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListbox
            // 
            this.panelListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panelListbox.Controls.Add(this.listBoxClient);
            this.panelListbox.Controls.Add(this.label1);
            this.panelListbox.Controls.Add(this.panel1);
            this.panelListbox.Location = new System.Drawing.Point(48, 29);
            this.panelListbox.Name = "panelListbox";
            this.panelListbox.Size = new System.Drawing.Size(472, 670);
            this.panelListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Image = global::AtCad.Properties.Resources.customer_32px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(166, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxClient
            // 
            this.listBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.listBoxClient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 18;
            this.listBoxClient.Location = new System.Drawing.Point(34, 106);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(400, 508);
            this.listBoxClient.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(139)))));
            this.panel1.Location = new System.Drawing.Point(26, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 528);
            this.panel1.TabIndex = 2;
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.panelListbox);
            this.Name = "ucClients";
            this.Size = new System.Drawing.Size(1100, 731);
            this.panelListbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListbox;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
