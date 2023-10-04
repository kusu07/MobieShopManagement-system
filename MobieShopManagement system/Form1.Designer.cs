using System;
using System.Windows.Forms;

namespace MobieShopManagement_system
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexist = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deletephonerecord = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customerrecords = new Guna.UI2.WinForms.Guna2Button();
            this.btn_stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addnewphone = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uc_customers1 = new MobieShopManagement_system.all_users.uc_customers();
            this.uc_add_new_phone1 = new MobieShopManagement_system.all_users.uc_add_new_phone();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_deletephonerecord);
            this.panel1.Controls.Add(this.btn_customerrecords);
            this.panel1.Controls.Add(this.btn_stock);
            this.panel1.Controls.Add(this.btn_customer);
            this.panel1.Controls.Add(this.btn_addnewphone);
            this.panel1.Controls.Add(this.btnexist);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 687);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phone Management ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexist
            // 
            this.btnexist.BackColor = System.Drawing.Color.Red;
            this.btnexist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexist.FillColor = System.Drawing.Color.Snow;
            this.btnexist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexist.ForeColor = System.Drawing.Color.Red;
            this.btnexist.Location = new System.Drawing.Point(12, 14);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(33, 40);
            this.btnexist.TabIndex = 0;
            this.btnexist.Text = "X";
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.panel2.BackgroundImage = global::MobieShopManagement_system.Properties.Resources.download;
            this.panel2.Controls.Add(this.uc_customers1);
            this.panel2.Controls.Add(this.uc_add_new_phone1);
            this.panel2.Location = new System.Drawing.Point(358, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 687);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // btn_deletephonerecord
            // 
            this.btn_deletephonerecord.BorderRadius = 15;
            this.btn_deletephonerecord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_deletephonerecord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_deletephonerecord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_deletephonerecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletephonerecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletephonerecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deletephonerecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deletephonerecord.FillColor = System.Drawing.Color.Transparent;
            this.btn_deletephonerecord.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_deletephonerecord.ForeColor = System.Drawing.Color.White;
            this.btn_deletephonerecord.Image = global::MobieShopManagement_system.Properties.Resources._6861362;
            this.btn_deletephonerecord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deletephonerecord.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_deletephonerecord.Location = new System.Drawing.Point(12, 392);
            this.btn_deletephonerecord.Name = "btn_deletephonerecord";
            this.btn_deletephonerecord.Size = new System.Drawing.Size(312, 45);
            this.btn_deletephonerecord.TabIndex = 5;
            this.btn_deletephonerecord.Text = " Delete Phone Record";
            // 
            // btn_customerrecords
            // 
            this.btn_customerrecords.BorderRadius = 15;
            this.btn_customerrecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_customerrecords.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_customerrecords.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_customerrecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customerrecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customerrecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customerrecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customerrecords.FillColor = System.Drawing.Color.Transparent;
            this.btn_customerrecords.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_customerrecords.ForeColor = System.Drawing.Color.White;
            this.btn_customerrecords.Image = global::MobieShopManagement_system.Properties.Resources._639375;
            this.btn_customerrecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_customerrecords.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_customerrecords.Location = new System.Drawing.Point(12, 310);
            this.btn_customerrecords.Name = "btn_customerrecords";
            this.btn_customerrecords.Size = new System.Drawing.Size(312, 45);
            this.btn_customerrecords.TabIndex = 4;
            this.btn_customerrecords.Text = "Customer Records";
            // 
            // btn_stock
            // 
            this.btn_stock.BorderRadius = 15;
            this.btn_stock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_stock.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_stock.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stock.FillColor = System.Drawing.Color.Transparent;
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Image = global::MobieShopManagement_system.Properties.Resources._2422796;
            this.btn_stock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_stock.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_stock.Location = new System.Drawing.Point(12, 232);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(312, 45);
            this.btn_stock.TabIndex = 3;
            this.btn_stock.Text = "Stock";
            // 
            // btn_customer
            // 
            this.btn_customer.BorderRadius = 15;
            this.btn_customer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_customer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_customer.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customer.FillColor = System.Drawing.Color.Transparent;
            this.btn_customer.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.Image = global::MobieShopManagement_system.Properties.Resources._3201521;
            this.btn_customer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_customer.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_customer.Location = new System.Drawing.Point(12, 157);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(312, 45);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Customers";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_addnewphone
            // 
            this.btn_addnewphone.BorderRadius = 15;
            this.btn_addnewphone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addnewphone.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addnewphone.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_addnewphone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnewphone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnewphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addnewphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addnewphone.FillColor = System.Drawing.Color.Transparent;
            this.btn_addnewphone.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnewphone.ForeColor = System.Drawing.Color.White;
            this.btn_addnewphone.Image = global::MobieShopManagement_system.Properties.Resources._2482945;
            this.btn_addnewphone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_addnewphone.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_addnewphone.Location = new System.Drawing.Point(12, 81);
            this.btn_addnewphone.Name = "btn_addnewphone";
            this.btn_addnewphone.Size = new System.Drawing.Size(312, 45);
            this.btn_addnewphone.TabIndex = 1;
            this.btn_addnewphone.Text = "Add New Phone";
            this.btn_addnewphone.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 26;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // uc_customers1
            // 
            this.uc_customers1.BackColor = System.Drawing.Color.White;
            this.uc_customers1.Location = new System.Drawing.Point(0, 0);
            this.uc_customers1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uc_customers1.Name = "uc_customers1";
            this.uc_customers1.Size = new System.Drawing.Size(1089, 687);
            this.uc_customers1.TabIndex = 1;
            // 
            // uc_add_new_phone1
            // 
            this.uc_add_new_phone1.BackColor = System.Drawing.Color.White;
            this.uc_add_new_phone1.Location = new System.Drawing.Point(0, 0);
            this.uc_add_new_phone1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uc_add_new_phone1.Name = "uc_add_new_phone1";
            this.uc_add_new_phone1.Size = new System.Drawing.Size(1089, 687);
            this.uc_add_new_phone1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1462, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnexist;
        private EventHandler Form1_Load;
        private Guna.UI2.WinForms.Guna2Button btn_addnewphone;
        private Guna.UI2.WinForms.Guna2Button btn_deletephonerecord;
        private Guna.UI2.WinForms.Guna2Button btn_customerrecords;
        private Guna.UI2.WinForms.Guna2Button btn_stock;
        private Guna.UI2.WinForms.Guna2Button btn_customer;
        private PaintEventHandler panel1_Paint;
        private PaintEventHandler panel2_Paint;
        private EventHandler guna2Button1_Click;
        private EventHandler guna2Button2_Click;
        private EventHandler guna2Button3_Click;
        private EventHandler guna2Button4_Click;
        private EventHandler guna2Button5_Click;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private all_users.uc_add_new_phone uc_add_new_phone1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private all_users.uc_customers uc_customers1;
    }
}

