using System;
using System.Windows.Forms;
using System.Linq;

namespace Loan_Management_System{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm: Form{
		
		public MainForm() {InitializeComponent();
			Module.LoadTable(dataGridView1); //Show the Table First
			loginUser_LB.Text = Login.user; //Save the login User
		}
		void Calculate_BTClick(object sender, EventArgs e) { //Calculate
			Module.Calculate(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB);
		}
		void Add_BTClick(object sender, EventArgs e) { //Add Data on Using Module Class
			Module.AddBtnFunction(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, dataGridView1, seachName_TB);
		}
		void Updates_BTClick(object sender, EventArgs e) { //Updates Data on Using Module Class
			Module.UpdatesBtnFunction(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, dataGridView1, seachName_TB);
		}
		void Delete_BTClick(object sender, EventArgs e) { //Updates Data on Using Module Class
			Module.DeleteBtnFunction(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, loginUser_LB, account_IDLB, dataGridView1, seachName_TB);
		}
		void ResetAll_BTClick(object sender, EventArgs e) { //Clear all Text box //Reset Button if the input is mistake
			Module.Clear(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, seachName_TB);
			MessageBox.Show("All Clear");
		}
		void Generate_TBClick(object sender, EventArgs e) { //Generate Receipt Button
			Module.Generate(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB);
		}
		//Menu Button
		void Menu_BTClick(object sender, EventArgs e) {
			this.Hide();
			Menu open = new Menu();
			open.Closed += (s, args) =>this.Close(); //Open new form Close this form completely
			open.Show();
		}
		void Exit_BTClick(object sender, EventArgs e) { //Exit Button
			Module.Exit();
		}
		//Data from the database
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e) {
			Module.DataGridView(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, dataGridView1, e);
		}
		//Check if the user input a letter that should be number
		void AmountLoan_TBTextChanged(object sender, EventArgs e) {
			//Text Changed check letter
			if (System.Text.RegularExpressions.Regex.IsMatch(amountLoan_TB.Text, "[^0-9 + . + , + $]")) {
				MessageBox.Show("Please enter only numbers.");
				amountLoan_TB.Text = amountLoan_TB.Text.Remove(amountLoan_TB.Text.Length - 1); //Remove input on textbox
			}
		}
		//Check if the user input a letter that should be number
		void NumberYear_TBTextChanged(object sender, EventArgs e) {
			//Text Changed check letter
			if (System.Text.RegularExpressions.Regex.IsMatch(numberYear_TB.Text, "[^0-9]")) {
				MessageBox.Show("Please enter only numbers.");
				numberYear_TB.Text = numberYear_TB.Text.Remove(numberYear_TB.Text.Length - 1); //Remove input on textbox
			}
		}
		//Check if the user input a letter that should be number
		void InterestRate_TBTextChanged(object sender, EventArgs e) {
			//Text Changed check letter
			if (System.Text.RegularExpressions.Regex.IsMatch(interestRate_TB.Text, "[^0-9 + .]")) {
				MessageBox.Show("Please enter only numbers.");
				interestRate_TB.Text = interestRate_TB.Text.Remove(interestRate_TB.Text.Length - 1); //Remove input on textbox
			}
		}
		//Search Text Box
		void SeachName_TBTextChanged(object sender, EventArgs e) {
			string search = seachName_TB.Text;
			Module.LoadTable(dataGridView1, search); //Search Action
		}
	}
}