
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetIDGen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelListbox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListbox
            // 
            this.panelListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panelListbox.Controls.Add(this.btnDisplay);
            this.panelListbox.Controls.Add(this.listBoxClient);
            this.panelListbox.Controls.Add(this.label1);
            this.panelListbox.Controls.Add(this.panel1);
            this.panelListbox.Location = new System.Drawing.Point(48, 29);
            this.panelListbox.Name = "panelListbox";
            this.panelListbox.Size = new System.Drawing.Size(472, 670);
            this.panelListbox.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.btnDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Roboto Cn", 13F);
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDisplay.Image = global::AtCad.Properties.Resources.loading_32px;
            this.btnDisplay.Location = new System.Drawing.Point(34, 49);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(119, 43);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplay.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(139)))));
            this.panel1.Location = new System.Drawing.Point(26, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 528);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.btnResetIDGen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textID);
            this.panel2.Controls.Add(this.textAddress);
            this.panel2.Controls.Add(this.textNumber);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(606, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 417);
            this.panel2.TabIndex = 1;
            // 
            // btnResetIDGen
            // 
            this.btnResetIDGen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetIDGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetIDGen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetIDGen.FlatAppearance.BorderSize = 0;
            this.btnResetIDGen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.btnResetIDGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnResetIDGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetIDGen.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetIDGen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnResetIDGen.Image = global::AtCad.Properties.Resources.restart_40px;
            this.btnResetIDGen.Location = new System.Drawing.Point(341, 96);
            this.btnResetIDGen.Name = "btnResetIDGen";
            this.btnResetIDGen.Size = new System.Drawing.Size(46, 41);
            this.btnResetIDGen.TabIndex = 7;
            this.btnResetIDGen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetIDGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetIDGen.UseVisualStyleBackColor = true;
            this.btnResetIDGen.Click += new System.EventHandler(this.btnResetIDGen_Click);
            // 
            // label2
            // 
            this.label2.Image = global::AtCad.Properties.Resources.client_management_64px;
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 56);
            this.label2.TabIndex = 4;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Roboto Cn", 16F);
            this.textID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.textID.Location = new System.Drawing.Point(85, 100);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(250, 36);
            this.textID.TabIndex = 3;
            this.textID.Text = "Client ID";
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Roboto Cn", 14F);
            this.textAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.textAddress.Location = new System.Drawing.Point(33, 253);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(354, 146);
            this.textAddress.TabIndex = 2;
            this.textAddress.Text = "Address";
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textAddress.Enter += new System.EventHandler(this.textAddress_Enter);
            this.textAddress.Leave += new System.EventHandler(this.textAddress_Leave);
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Roboto Cn", 16F);
            this.textNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.textNumber.Location = new System.Drawing.Point(85, 202);
            this.textNumber.Multiline = true;
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(250, 36);
            this.textNumber.TabIndex = 1;
            this.textNumber.Text = "Contact Number";
            this.textNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNumber.Enter += new System.EventHandler(this.textNumber_Enter);
            this.textNumber.Layout += new System.Windows.Forms.LayoutEventHandler(this.textNumber_Layout);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Roboto Cn", 16F);
            this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.textName.Location = new System.Drawing.Point(85, 151);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(250, 36);
            this.textName.TabIndex = 0;
            this.textName.Text = "Client Name";
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textName.Enter += new System.EventHandler(this.textName_Enter);
            this.textName.Leave += new System.EventHandler(this.textName_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Image = global::AtCad.Properties.Resources.update_32px;
            this.btnUpdate.Location = new System.Drawing.Point(616, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Image = global::AtCad.Properties.Resources.minus_24px;
            this.btnDelete.Location = new System.Drawing.Point(878, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Image = global::AtCad.Properties.Resources.plus_24px;
            this.btnAdd.Location = new System.Drawing.Point(747, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelListbox);
            this.Name = "ucClients";
            this.Size = new System.Drawing.Size(1100, 731);
            this.panelListbox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListbox;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetIDGen;
    }
}
