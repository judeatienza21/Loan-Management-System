/*
 * Created by SharpDevelop.
 * User: Jude
 * Date: 2/12/2021
 * Time: 10:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Loan_Management_System
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox passWord_TB;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox userName_TB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button login_BT;
		
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
			this.login_BT = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.passWord_TB = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.userName_TB = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.login_BT);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.passWord_TB);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.userName_TB);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 234);
			this.panel1.TabIndex = 0;
			// 
			// login_BT
			// 
			this.login_BT.BackColor = System.Drawing.Color.White;
			this.login_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.login_BT.Location = new System.Drawing.Point(165, 160);
			this.login_BT.Name = "login_BT";
			this.login_BT.Size = new System.Drawing.Size(120, 35);
			this.login_BT.TabIndex = 77;
			this.login_BT.Text = "Login";
			this.login_BT.UseVisualStyleBackColor = false;
			this.login_BT.Click += new System.EventHandler(this.Login_BTClick);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label11.Location = new System.Drawing.Point(17, 119);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(123, 16);
			this.label11.TabIndex = 76;
			this.label11.Text = "Company password:";
			// 
			// passWord_TB
			// 
			this.passWord_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.passWord_TB.Location = new System.Drawing.Point(142, 112);
			this.passWord_TB.Multiline = true;
			this.passWord_TB.Name = "passWord_TB";
			this.passWord_TB.Size = new System.Drawing.Size(161, 25);
			this.passWord_TB.TabIndex = 75;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(17, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 16);
			this.label10.TabIndex = 74;
			this.label10.Text = "Employee Name:";
			// 
			// userName_TB
			// 
			this.userName_TB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.userName_TB.Location = new System.Drawing.Point(142, 67);
			this.userName_TB.Multiline = true;
			this.userName_TB.Name = "userName_TB";
			this.userName_TB.Size = new System.Drawing.Size(161, 25);
			this.userName_TB.TabIndex = 73;
			this.userName_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserName_TBKeyDown);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 234);
			this.Controls.Add(this.panel1);
			this.Name = "Login";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
