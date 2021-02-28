/*
 * Created by SharpDevelop.
 * User: Jude
 * Date: 2/2/2021
 * Time: 8:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Loan_Management_System
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button calculate_BT;
		private System.Windows.Forms.Button add_BT;
		private System.Windows.Forms.Button exit_BT;
		private System.Windows.Forms.Button updates_BT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox amountLoan_TB;
		private System.Windows.Forms.TextBox numberYear_TB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox interestRate_TB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox firstName_TB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label monthlyPay_LB;
		private System.Windows.Forms.Label totalPay_LB;
		private System.Windows.Forms.Button delete_BT;
		private System.Windows.Forms.Label account_IDLB;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox middleName_TB;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox lastName_TB;
		private System.Windows.Forms.Button resetAll_BT;
		private System.Windows.Forms.Button generate_TB;
		private System.Windows.Forms.TextBox acconAddress_TB;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox seachName_TB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button menu_BT;
		private System.Windows.Forms.Label loginUser_LB;
		private System.Windows.Forms.Label label14;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.loginUser_LB = new System.Windows.Forms.Label();
			this.menu_BT = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.seachName_TB = new System.Windows.Forms.TextBox();
			this.resetAll_BT = new System.Windows.Forms.Button();
			this.generate_TB = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.lastName_TB = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.middleName_TB = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.account_IDLB = new System.Windows.Forms.Label();
			this.delete_BT = new System.Windows.Forms.Button();
			this.totalPay_LB = new System.Windows.Forms.Label();
			this.monthlyPay_LB = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.acconAddress_TB = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.firstName_TB = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.exit_BT = new System.Windows.Forms.Button();
			this.updates_BT = new System.Windows.Forms.Button();
			this.add_BT = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.interestRate_TB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numberYear_TB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.amountLoan_TB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.calculate_BT = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.loginUser_LB);
			this.panel1.Controls.Add(this.menu_BT);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.seachName_TB);
			this.panel1.Controls.Add(this.resetAll_BT);
			this.panel1.Controls.Add(this.generate_TB);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.lastName_TB);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.middleName_TB);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.account_IDLB);
			this.panel1.Controls.Add(this.delete_BT);
			this.panel1.Controls.Add(this.totalPay_LB);
			this.panel1.Controls.Add(this.monthlyPay_LB);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.acconAddress_TB);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.firstName_TB);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.exit_BT);
			this.panel1.Controls.Add(this.updates_BT);
			this.panel1.Controls.Add(this.add_BT);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.interestRate_TB);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numberYear_TB);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.amountLoan_TB);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.calculate_BT);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(754, 542);
			this.panel1.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(13, 506);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(77, 27);
			this.label14.TabIndex = 77;
			this.label14.Text = "Login name: ";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loginUser_LB
			// 
			this.loginUser_LB.BackColor = System.Drawing.Color.Transparent;
			this.loginUser_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginUser_LB.Location = new System.Drawing.Point(87, 506);
			this.loginUser_LB.Name = "loginUser_LB";
			this.loginUser_LB.Size = new System.Drawing.Size(204, 27);
			this.loginUser_LB.TabIndex = 76;
			this.loginUser_LB.Text = "User";
			this.loginUser_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menu_BT
			// 
			this.menu_BT.BackColor = System.Drawing.Color.White;
			this.menu_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.menu_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.menu_BT.Location = new System.Drawing.Point(317, 453);
			this.menu_BT.Name = "menu_BT";
			this.menu_BT.Size = new System.Drawing.Size(120, 35);
			this.menu_BT.TabIndex = 75;
			this.menu_BT.Text = "Menu";
			this.menu_BT.UseVisualStyleBackColor = false;
			this.menu_BT.Click += new System.EventHandler(this.Menu_BTClick);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label13.Location = new System.Drawing.Point(526, 462);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 16);
			this.label13.TabIndex = 74;
			this.label13.Text = "Search: ";
			// 
			// seachName_TB
			// 
			this.seachName_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.seachName_TB.Location = new System.Drawing.Point(577, 459);
			this.seachName_TB.Multiline = true;
			this.seachName_TB.Name = "seachName_TB";
			this.seachName_TB.Size = new System.Drawing.Size(152, 25);
			this.seachName_TB.TabIndex = 73;
			this.seachName_TB.TextChanged += new System.EventHandler(this.SeachName_TBTextChanged);
			// 
			// resetAll_BT
			// 
			this.resetAll_BT.BackColor = System.Drawing.Color.White;
			this.resetAll_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.resetAll_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.resetAll_BT.Location = new System.Drawing.Point(171, 453);
			this.resetAll_BT.Name = "resetAll_BT";
			this.resetAll_BT.Size = new System.Drawing.Size(120, 35);
			this.resetAll_BT.TabIndex = 71;
			this.resetAll_BT.Text = "Reset Loan";
			this.resetAll_BT.UseVisualStyleBackColor = false;
			this.resetAll_BT.Click += new System.EventHandler(this.ResetAll_BTClick);
			// 
			// generate_TB
			// 
			this.generate_TB.BackColor = System.Drawing.Color.White;
			this.generate_TB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.generate_TB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.generate_TB.Location = new System.Drawing.Point(25, 453);
			this.generate_TB.Name = "generate_TB";
			this.generate_TB.Size = new System.Drawing.Size(120, 35);
			this.generate_TB.TabIndex = 70;
			this.generate_TB.Text = "Generate Receipt";
			this.generate_TB.UseVisualStyleBackColor = false;
			this.generate_TB.Click += new System.EventHandler(this.Generate_TBClick);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(466, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 16);
			this.label12.TabIndex = 69;
			this.label12.Text = "Lastname";
			// 
			// lastName_TB
			// 
			this.lastName_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.lastName_TB.Location = new System.Drawing.Point(431, 128);
			this.lastName_TB.Multiline = true;
			this.lastName_TB.Name = "lastName_TB";
			this.lastName_TB.Size = new System.Drawing.Size(132, 25);
			this.lastName_TB.TabIndex = 68;
			this.lastName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label11.Location = new System.Drawing.Point(317, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(86, 16);
			this.label11.TabIndex = 67;
			this.label11.Text = "Middle Name";
			// 
			// middleName_TB
			// 
			this.middleName_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.middleName_TB.Location = new System.Drawing.Point(293, 128);
			this.middleName_TB.Multiline = true;
			this.middleName_TB.Name = "middleName_TB";
			this.middleName_TB.Size = new System.Drawing.Size(132, 25);
			this.middleName_TB.TabIndex = 66;
			this.middleName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(184, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 16);
			this.label10.TabIndex = 65;
			this.label10.Text = "Firstname";
			// 
			// account_IDLB
			// 
			this.account_IDLB.BackColor = System.Drawing.SystemColors.Window;
			this.account_IDLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.account_IDLB.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
			this.account_IDLB.ForeColor = System.Drawing.SystemColors.InfoText;
			this.account_IDLB.Location = new System.Drawing.Point(647, 61);
			this.account_IDLB.Name = "account_IDLB";
			this.account_IDLB.Size = new System.Drawing.Size(95, 30);
			this.account_IDLB.TabIndex = 64;
			this.account_IDLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// delete_BT
			// 
			this.delete_BT.BackColor = System.Drawing.Color.White;
			this.delete_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.delete_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.delete_BT.Location = new System.Drawing.Point(463, 399);
			this.delete_BT.Name = "delete_BT";
			this.delete_BT.Size = new System.Drawing.Size(120, 35);
			this.delete_BT.TabIndex = 63;
			this.delete_BT.Text = "Delete Loan";
			this.delete_BT.UseVisualStyleBackColor = false;
			this.delete_BT.Click += new System.EventHandler(this.Delete_BTClick);
			// 
			// totalPay_LB
			// 
			this.totalPay_LB.BackColor = System.Drawing.SystemColors.Window;
			this.totalPay_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.totalPay_LB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.totalPay_LB.ForeColor = System.Drawing.SystemColors.WindowText;
			this.totalPay_LB.Location = new System.Drawing.Point(417, 68);
			this.totalPay_LB.Name = "totalPay_LB";
			this.totalPay_LB.Size = new System.Drawing.Size(209, 23);
			this.totalPay_LB.TabIndex = 62;
			this.totalPay_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// monthlyPay_LB
			// 
			this.monthlyPay_LB.BackColor = System.Drawing.SystemColors.Window;
			this.monthlyPay_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.monthlyPay_LB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.monthlyPay_LB.ForeColor = System.Drawing.SystemColors.WindowText;
			this.monthlyPay_LB.Location = new System.Drawing.Point(417, 30);
			this.monthlyPay_LB.Name = "monthlyPay_LB";
			this.monthlyPay_LB.Size = new System.Drawing.Size(209, 23);
			this.monthlyPay_LB.TabIndex = 61;
			this.monthlyPay_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(647, 38);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 27);
			this.label9.TabIndex = 60;
			this.label9.Text = "Costomers ID ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Window;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(265, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 20);
			this.label8.TabIndex = 59;
			this.label8.Text = "%";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// acconAddress_TB
			// 
			this.acconAddress_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.acconAddress_TB.Location = new System.Drawing.Point(150, 159);
			this.acconAddress_TB.Multiline = true;
			this.acconAddress_TB.Name = "acconAddress_TB";
			this.acconAddress_TB.Size = new System.Drawing.Size(591, 25);
			this.acconAddress_TB.TabIndex = 58;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(13, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 27);
			this.label7.TabIndex = 57;
			this.label7.Text = "Address of Customer: ";
			// 
			// firstName_TB
			// 
			this.firstName_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.firstName_TB.Location = new System.Drawing.Point(149, 128);
			this.firstName_TB.Multiline = true;
			this.firstName_TB.Name = "firstName_TB";
			this.firstName_TB.Size = new System.Drawing.Size(132, 25);
			this.firstName_TB.TabIndex = 56;
			this.firstName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(13, 126);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 27);
			this.label6.TabIndex = 55;
			this.label6.Text = "Name of Costumers:";
			// 
			// exit_BT
			// 
			this.exit_BT.BackColor = System.Drawing.Color.White;
			this.exit_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.exit_BT.Location = new System.Drawing.Point(609, 399);
			this.exit_BT.Name = "exit_BT";
			this.exit_BT.Size = new System.Drawing.Size(120, 35);
			this.exit_BT.TabIndex = 54;
			this.exit_BT.Text = "Exit";
			this.exit_BT.UseVisualStyleBackColor = false;
			this.exit_BT.Click += new System.EventHandler(this.Exit_BTClick);
			// 
			// updates_BT
			// 
			this.updates_BT.BackColor = System.Drawing.Color.White;
			this.updates_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.updates_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.updates_BT.Location = new System.Drawing.Point(317, 399);
			this.updates_BT.Name = "updates_BT";
			this.updates_BT.Size = new System.Drawing.Size(120, 35);
			this.updates_BT.TabIndex = 53;
			this.updates_BT.Text = "Updates Loan";
			this.updates_BT.UseVisualStyleBackColor = false;
			this.updates_BT.Click += new System.EventHandler(this.Updates_BTClick);
			// 
			// add_BT
			// 
			this.add_BT.BackColor = System.Drawing.Color.White;
			this.add_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.add_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.add_BT.Location = new System.Drawing.Point(171, 399);
			this.add_BT.Name = "add_BT";
			this.add_BT.Size = new System.Drawing.Size(120, 35);
			this.add_BT.TabIndex = 52;
			this.add_BT.Text = "Add Loan";
			this.add_BT.UseVisualStyleBackColor = false;
			this.add_BT.Click += new System.EventHandler(this.Add_BTClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView1.Location = new System.Drawing.Point(13, 193);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(728, 188);
			this.dataGridView1.TabIndex = 51;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(305, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 27);
			this.label5.TabIndex = 50;
			this.label5.Text = "Total Payment: ";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(305, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 27);
			this.label4.TabIndex = 49;
			this.label4.Text = "Monthly Payment: ";
			// 
			// interestRate_TB
			// 
			this.interestRate_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.interestRate_TB.Location = new System.Drawing.Point(150, 81);
			this.interestRate_TB.Multiline = true;
			this.interestRate_TB.Name = "interestRate_TB";
			this.interestRate_TB.Size = new System.Drawing.Size(132, 25);
			this.interestRate_TB.TabIndex = 48;
			this.interestRate_TB.TextChanged += new System.EventHandler(this.InterestRate_TBTextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(12, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 27);
			this.label3.TabIndex = 47;
			this.label3.Text = "Enter Interest Rate: ";
			// 
			// numberYear_TB
			// 
			this.numberYear_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.numberYear_TB.Location = new System.Drawing.Point(150, 46);
			this.numberYear_TB.Multiline = true;
			this.numberYear_TB.Name = "numberYear_TB";
			this.numberYear_TB.Size = new System.Drawing.Size(132, 25);
			this.numberYear_TB.TabIndex = 46;
			this.numberYear_TB.TextChanged += new System.EventHandler(this.NumberYear_TBTextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(13, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 27);
			this.label2.TabIndex = 45;
			this.label2.Text = "Enter Number of Year: ";
			// 
			// amountLoan_TB
			// 
			this.amountLoan_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.amountLoan_TB.Location = new System.Drawing.Point(149, 11);
			this.amountLoan_TB.Multiline = true;
			this.amountLoan_TB.Name = "amountLoan_TB";
			this.amountLoan_TB.Size = new System.Drawing.Size(133, 25);
			this.amountLoan_TB.TabIndex = 44;
			this.amountLoan_TB.TextChanged += new System.EventHandler(this.AmountLoan_TBTextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Amount of Loan: ";
			// 
			// calculate_BT
			// 
			this.calculate_BT.BackColor = System.Drawing.Color.White;
			this.calculate_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.calculate_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.calculate_BT.Location = new System.Drawing.Point(25, 399);
			this.calculate_BT.Name = "calculate_BT";
			this.calculate_BT.Size = new System.Drawing.Size(120, 35);
			this.calculate_BT.TabIndex = 42;
			this.calculate_BT.Text = "Calculate Loan";
			this.calculate_BT.UseVisualStyleBackColor = false;
			this.calculate_BT.Click += new System.EventHandler(this.Calculate_BTClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(754, 542);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loan Management System";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
