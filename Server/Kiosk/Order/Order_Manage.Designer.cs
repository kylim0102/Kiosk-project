﻿namespace Kiosk.Order
{
    partial class Order_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.selected_menu = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menulist = new System.Windows.Forms.TabControl();
            this.Mysql_tab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.option1 = new System.Windows.Forms.TabPage();
            this.op4 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Button();
            this.op1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.selected_menu)).BeginInit();
            this.menulist.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.option1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "영업일자 :";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(936, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(45, 15);
            this.date.TabIndex = 2;
            this.date.Text = "label2";
            // 
            // selected_menu
            // 
            this.selected_menu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selected_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selected_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu,
            this.Count,
            this.Price,
            this.Etc});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selected_menu.DefaultCellStyle = dataGridViewCellStyle10;
            this.selected_menu.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.selected_menu.Location = new System.Drawing.Point(49, 36);
            this.selected_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selected_menu.Name = "selected_menu";
            this.selected_menu.ReadOnly = true;
            this.selected_menu.RowHeadersVisible = false;
            this.selected_menu.RowHeadersWidth = 51;
            this.selected_menu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.selected_menu.RowTemplate.Height = 23;
            this.selected_menu.Size = new System.Drawing.Size(393, 371);
            this.selected_menu.TabIndex = 0;
            this.selected_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Menu
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Menu.DefaultCellStyle = dataGridViewCellStyle6;
            this.Menu.HeaderText = "메뉴";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            this.Menu.Width = 140;
            // 
            // Count
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Count.DefaultCellStyle = dataGridViewCellStyle7;
            this.Count.HeaderText = "수량";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 60;
            // 
            // Price
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price.DefaultCellStyle = dataGridViewCellStyle8;
            this.Price.HeaderText = "금액";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // Etc
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Etc.DefaultCellStyle = dataGridViewCellStyle9;
            this.Etc.HeaderText = "비고";
            this.Etc.MinimumWidth = 6;
            this.Etc.Name = "Etc";
            this.Etc.ReadOnly = true;
            this.Etc.Width = 60;
            // 
            // menulist
            // 
            this.menulist.Controls.Add(this.Mysql_tab);
            this.menulist.ItemSize = new System.Drawing.Size(100, 25);
            this.menulist.Location = new System.Drawing.Point(530, 36);
            this.menulist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menulist.Name = "menulist";
            this.menulist.SelectedIndex = 0;
            this.menulist.Size = new System.Drawing.Size(522, 504);
            this.menulist.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.menulist.TabIndex = 1;
            // 
            // Mysql_tab
            // 
            this.Mysql_tab.Location = new System.Drawing.Point(4, 29);
            this.Mysql_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mysql_tab.Name = "Mysql_tab";
            this.Mysql_tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mysql_tab.Size = new System.Drawing.Size(514, 471);
            this.Mysql_tab.TabIndex = 4;
            this.Mysql_tab.Text = "Mysql";
            this.Mysql_tab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.option1);
            this.tabControl1.Location = new System.Drawing.Point(535, 549);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 159);
            this.tabControl1.TabIndex = 2;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.option1.Controls.Add(this.op4);
            this.option1.Controls.Add(this.op3);
            this.option1.Controls.Add(this.op2);
            this.option1.Controls.Add(this.op1);
            this.option1.Location = new System.Drawing.Point(4, 25);
            this.option1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option1.Name = "option1";
            this.option1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option1.Size = new System.Drawing.Size(510, 130);
            this.option1.TabIndex = 0;
            this.option1.Text = "옵션";
            // 
            // op4
            // 
            this.op4.BackColor = System.Drawing.Color.DarkViolet;
            this.op4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.op4.Location = new System.Drawing.Point(403, 18);
            this.op4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(86, 94);
            this.op4.TabIndex = 14;
            this.op4.UseVisualStyleBackColor = false;
            // 
            // op3
            // 
            this.op3.BackColor = System.Drawing.Color.DarkViolet;
            this.op3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.op3.Location = new System.Drawing.Point(280, 18);
            this.op3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(86, 94);
            this.op3.TabIndex = 13;
            this.op3.UseVisualStyleBackColor = false;
            // 
            // op2
            // 
            this.op2.BackColor = System.Drawing.Color.DarkViolet;
            this.op2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.op2.Location = new System.Drawing.Point(146, 18);
            this.op2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(86, 94);
            this.op2.TabIndex = 12;
            this.op2.Text = "연하게";
            this.op2.UseVisualStyleBackColor = false;
            // 
            // op1
            // 
            this.op1.BackColor = System.Drawing.Color.DarkViolet;
            this.op1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.op1.Location = new System.Drawing.Point(13, 18);
            this.op1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(86, 94);
            this.op1.TabIndex = 11;
            this.op1.Text = "샷추가";
            this.op1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "총 결제 금액: ";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.payment.Location = new System.Drawing.Point(265, 430);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(24, 24);
            this.payment.TabIndex = 9;
            this.payment.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(49, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "현금";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(269, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 68);
            this.button2.TabIndex = 13;
            this.button2.Text = "카드";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.menulist);
            this.groupBox1.Controls.Add(this.selected_menu);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1086, 715);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문 관리";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Order_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 785);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Order_Manage";
            this.Text = "Order_Manage";
            this.Load += new System.EventHandler(this.Order_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selected_menu)).EndInit();
            this.menulist.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.option1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DataGridView selected_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etc;
        private System.Windows.Forms.TabControl menulist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage option1;
        private System.Windows.Forms.Button op4;
        private System.Windows.Forms.Button op3;
        private System.Windows.Forms.Button op2;
        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Mysql_tab;
    }
}