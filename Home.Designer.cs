namespace Actors_Trivia
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftHomeSideBar = new System.Windows.Forms.Panel();
            this.btnActorTrivia = new System.Windows.Forms.Button();
            this.topHomeBar = new System.Windows.Forms.Panel();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAddFromArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.tabPageTrivia = new System.Windows.Forms.TabPage();
            this.leftHomeSideBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftHomeSideBar
            // 
            this.leftHomeSideBar.BackColor = System.Drawing.Color.Navy;
            this.leftHomeSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftHomeSideBar.Controls.Add(this.btnActorTrivia);
            this.leftHomeSideBar.Controls.Add(this.topHomeBar);
            this.leftHomeSideBar.Controls.Add(this.btnAddActor);
            this.leftHomeSideBar.Location = new System.Drawing.Point(-3, -1);
            this.leftHomeSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftHomeSideBar.Name = "leftHomeSideBar";
            this.leftHomeSideBar.Size = new System.Drawing.Size(171, 454);
            this.leftHomeSideBar.TabIndex = 1;
            // 
            // btnActorTrivia
            // 
            this.btnActorTrivia.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorTrivia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnActorTrivia.Location = new System.Drawing.Point(23, 395);
            this.btnActorTrivia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActorTrivia.Name = "btnActorTrivia";
            this.btnActorTrivia.Size = new System.Drawing.Size(134, 31);
            this.btnActorTrivia.TabIndex = 9;
            this.btnActorTrivia.Text = "Actor Trivia";
            this.btnActorTrivia.UseVisualStyleBackColor = true;
            this.btnActorTrivia.Click += new System.EventHandler(this.button3_Click);
            // 
            // topHomeBar
            // 
            this.topHomeBar.BackColor = System.Drawing.Color.Blue;
            this.topHomeBar.Location = new System.Drawing.Point(161, 2);
            this.topHomeBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topHomeBar.Name = "topHomeBar";
            this.topHomeBar.Size = new System.Drawing.Size(647, 44);
            this.topHomeBar.TabIndex = 2;
            this.topHomeBar.Paint += new System.Windows.Forms.PaintEventHandler(this.topHomeBar_Paint);
            // 
            // btnAddActor
            // 
            this.btnAddActor.Font = new System.Drawing.Font("Showcard Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddActor.Location = new System.Drawing.Point(23, 20);
            this.btnAddActor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(134, 41);
            this.btnAddActor.TabIndex = 4;
            this.btnAddActor.Text = "Add Actor\r\n Manually\r\n";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.AddFromCode);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(375, 262);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(397, 62);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "jk";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged_1);
            // 
            // btnAddFromArray
            // 
            this.btnAddFromArray.Location = new System.Drawing.Point(416, 115);
            this.btnAddFromArray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFromArray.Name = "btnAddFromArray";
            this.btnAddFromArray.Size = new System.Drawing.Size(188, 39);
            this.btnAddFromArray.TabIndex = 6;
            this.btnAddFromArray.Text = "Add items from array";
            this.btnAddFromArray.UseVisualStyleBackColor = true;
            this.btnAddFromArray.Click += new System.EventHandler(this.AddFromArray);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Selected Index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getSelectedIndex);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Get Selected Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.getSelectedItem);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageTrivia);
            this.tabControl1.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Italic);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 550);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.Black;
            this.tabPageHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageHome.Controls.Add(this.panel3);
            this.tabPageHome.Controls.Add(this.leftHomeSideBar);
            this.tabPageHome.Controls.Add(this.txtInput);
            this.tabPageHome.Controls.Add(this.button2);
            this.tabPageHome.Controls.Add(this.lstItems);
            this.tabPageHome.Controls.Add(this.button1);
            this.tabPageHome.Controls.Add(this.btnAddFromArray);
            this.tabPageHome.Location = new System.Drawing.Point(4, 52);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageHome.Size = new System.Drawing.Size(912, 494);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(196, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 272);
            this.panel3.TabIndex = 10;
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.ForeColor = System.Drawing.Color.Gold;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 17;
            this.lstItems.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.lstItems.Location = new System.Drawing.Point(172, 11);
            this.lstItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(600, 38);
            this.lstItems.TabIndex = 3;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // tabPageTrivia
            // 
            this.tabPageTrivia.Location = new System.Drawing.Point(4, 52);
            this.tabPageTrivia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTrivia.Name = "tabPageTrivia";
            this.tabPageTrivia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTrivia.Size = new System.Drawing.Size(912, 494);
            this.tabPageTrivia.TabIndex = 1;
            this.tabPageTrivia.Text = "tabPage2";
            this.tabPageTrivia.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1095, 540);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Add Items From Array";
            this.Load += new System.EventHandler(this.Home_Load);
            this.leftHomeSideBar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftHomeSideBar;
        private System.Windows.Forms.Panel topHomeBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddFromArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageTrivia;
        private System.Windows.Forms.Button btnActorTrivia;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Panel panel3;
    }
}

