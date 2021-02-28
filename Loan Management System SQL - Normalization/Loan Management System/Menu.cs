/*
 * Created by SharpDevelop.
 * User: Jude
 * Date: 2/12/2021
 * Time: 10:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loan_Management_System {
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu: Form {
		
		public Menu() {InitializeComponent();}
		
		void ViewLoans_BTClick(object sender, EventArgs e) {
			this.Hide();
			ViewLoans open = new ViewLoans();
			open.Closed += (s, args) =>this.Close(); //Open new form Close this form completely
			open.Show();
		}
		void LoanSystem_BTClick(object sender, EventArgs e) {
			this.Hide();
			MainForm open = new MainForm();
			open.Closed += (s, args) =>this.Close(); //Open new form Close this form completely
			open.Show();
		}
		void Exit_BTClick(object sender, EventArgs e) {
			Module.Exit();
		}
	}
}