/*
 * Created by SharpDevelop.
 * User: Jude
 * Date: 2/12/2021
 * Time: 10:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Loan_Management_System
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public static string user;
		private string pass = "admin";
		
		public Login()
		{
			InitializeComponent();
			
			passWord_TB.Text = "admin";
			passWord_TB.PasswordChar = '*';
			passWord_TB.MaxLength = 11;
			
		}
		//Click Mouse
		void Login_BTClick(object sender, EventArgs e)
		{
			//Pass the word
			user = userName_TB.Text;
			
			//Check Username and Password
			if(!userName_TB.Text.Equals("")){
				if (passWord_TB.Text.Equals(pass)){  
						this.Hide();
						Menu open = new Menu();
						open.Closed += (s, args) =>this.Close(); //Open new form Close this form completely
						MessageBox.Show("Welcome to Loan Management System \n                  Employee: " + userName_TB.Text);
						open.Show();                
	            }else{
	                MessageBox.Show("Invalid Login please check password");  
					}
			}else{
				MessageBox.Show("The Employee name is Empty");  
			}
		}
		//Enter keyboard key
		void UserName_TBKeyDown(object sender, KeyEventArgs e)
		{
			//Pass the word
			user = userName_TB.Text;
			
            if (e.KeyCode == Keys.Enter){
				//Check Username and Password
				if(!userName_TB.Text.Equals("")){
					if (passWord_TB.Text.Equals(pass)){
								this.Hide();
								Menu open = new Menu();
								open.Closed += (s, args) =>this.Close(); //Open new form Close this form completely
								MessageBox.Show("Welcome to Loan Management System \n                  Employee: " + userName_TB.Text);
								open.Show();                
			            }else{
			                MessageBox.Show("Invalid Login please check password");  
							}
				}else{
					MessageBox.Show("The Employee name is Empty");
					userName_TB.Text = "";					
				}
        	}
        }
	}
}
