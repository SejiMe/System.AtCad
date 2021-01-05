
namespace AtCad
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 89);
            this.topPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1027, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 89);
            this.panel1.TabIndex = 3;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Digital-7", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(81, 32);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(98, 22);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "SATURDAY";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(58, 55);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(144, 28);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "HH/ MM / MS";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(42, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(176, 28);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "MM/ DD / YYYY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "This is the Business System Name";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.leftPanel.Controls.Add(this.leftMainPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 89);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(180, 731);
            this.leftPanel.TabIndex = 1;
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftMainPanel.Controls.Add(this.label3);
            this.leftMainPanel.Controls.Add(this.btnExit);
            this.leftMainPanel.Controls.Add(this.btnRecords);
            this.leftMainPanel.Controls.Add(this.btnTransactions);
            this.leftMainPanel.Controls.Add(this.btnInventory);
            this.leftMainPanel.Controls.Add(this.btnDashboard);
            this.leftMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(180, 731);
            this.leftMainPanel.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::AtCad.Properties.Resources.logout_rounded_down_32px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(9, 652);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Session Out";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Image = global::AtCad.Properties.Resources.moleskine_24px;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(12, 148);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(139, 40);
            this.btnRecords.TabIndex = 6;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.Image = global::AtCad.Properties.Resources.inventory_flow_32px;
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(12, 213);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(139, 40);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = global::AtCad.Properties.Resources.warehouse_32px;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(12, 278);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(139, 40);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "MENU";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::AtCad.Properties.Resources.combo_chart_26px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 83);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(139, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(180, 89);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 731);
            this.mainPanel.TabIndex = 2;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 820);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftMainPanel.ResumeLayout(false);
            this.leftMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lblDay;
    }
}

