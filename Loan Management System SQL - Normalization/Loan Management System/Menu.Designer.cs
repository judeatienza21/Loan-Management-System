/*
 * Created by SharpDevelop.
 * User: Jude
 * Date: 2/12/2021
 * Time: 10:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Loan_Management_System
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button viewLoans_BT;
		private System.Windows.Forms.Button exit_BT;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button loanSystem_BT;
		
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
			this.viewLoans_BT = new System.Windows.Forms.Button();
			this.exit_BT = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.loanSystem_BT = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewLoans_BT
			// 
			this.viewLoans_BT.BackColor = System.Drawing.Color.White;
			this.viewLoans_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.viewLoans_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.viewLoans_BT.Location = new System.Drawing.Point(68, 101);
			this.viewLoans_BT.Name = "viewLoans_BT";
			this.viewLoans_BT.Size = new System.Drawing.Size(120, 35);
			this.viewLoans_BT.TabIndex = 64;
			this.viewLoans_BT.Text = "View Loans";
			this.viewLoans_BT.UseVisualStyleBackColor = false;
			this.viewLoans_BT.Click += new System.EventHandler(this.ViewLoans_BTClick);
			// 
			// exit_BT
			// 
			this.exit_BT.BackColor = System.Drawing.Color.White;
			this.exit_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.exit_BT.Location = new System.Drawing.Point(68, 167);
			this.exit_BT.Name = "exit_BT";
			this.exit_BT.Size = new System.Drawing.Size(120, 35);
			this.exit_BT.TabIndex = 65;
			this.exit_BT.Text = "Exit";
			this.exit_BT.UseVisualStyleBackColor = false;
			this.exit_BT.Click += new System.EventHandler(this.Exit_BTClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.loanSystem_BT);
			this.panel1.Controls.Add(this.viewLoans_BT);
			this.panel1.Controls.Add(this.exit_BT);
			this.panel1.Location = new System.Drawing.Point(1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 255);
			this.panel1.TabIndex = 70;
			// 
			// loanSystem_BT
			// 
			this.loanSystem_BT.BackColor = System.Drawing.Color.White;
			this.loanSystem_BT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loanSystem_BT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
			this.loanSystem_BT.Location = new System.Drawing.Point(68, 30);
			this.loanSystem_BT.Name = "loanSystem_BT";
			this.loanSystem_BT.Size = new System.Drawing.Size(120, 35);
			this.loanSystem_BT.TabIndex = 66;
			this.loanSystem_BT.Text = "Loans System";
			this.loanSystem_BT.UseVisualStyleBackColor = false;
			this.loanSystem_BT.Click += new System.EventHandler(this.LoanSystem_BTClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 247);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
