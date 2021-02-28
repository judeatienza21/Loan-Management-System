using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loan_Management_System {
	/// <summary>
	/// Description of Modules.
	/// </summary>
	public class Module : Database { //Connection
		
		static double amount_Loan, number_Year, interest_Rate, interestMonthly_Rate, MonthlyPayment, TotalOfPayment; //Variable for textBox
		static string iMonthlyPayment, ITotalPayment,IAmount; //Variable for equations
		
		//Calculate			
		public static void Calculate(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB) {
			//Checking if Empty
			if (amountLoan_TB.Text.Equals("") || numberYear_TB.Text.Equals("")  || interestRate_TB.Text.Equals("")){
				MessageBox.Show("Please fill up all the fields!!");
			}else{
				if(amountLoan_TB.Text.Contains("$"))
				{
					amountLoan_TB.Text = amountLoan_TB.Text.Substring(1);
					
					if(!amountLoan_TB.Text.Contains("$")){
						amount_Loan = Convert.ToDouble(amountLoan_TB.Text);
						number_Year = Convert.ToDouble(numberYear_TB.Text);
						interest_Rate = Convert.ToDouble(interestRate_TB.Text);
						interestMonthly_Rate = interest_Rate / 1200;
		
						//Monthly Payment equation
						MonthlyPayment = amount_Loan * interestMonthly_Rate / (1 - 1 / Math.Pow(1 + interestMonthly_Rate, number_Year * 12));
		
						iMonthlyPayment = Convert.ToString(MonthlyPayment);
						iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
						monthlyPay_LB.Text = Convert.ToString(iMonthlyPayment);
		
						//Total Payment equation
						TotalOfPayment = MonthlyPayment * number_Year * 12;
		
						ITotalPayment = Convert.ToString(TotalOfPayment);
						ITotalPayment = String.Format("{0:C}", TotalOfPayment);
						totalPay_LB.Text = Convert.ToString(ITotalPayment);
						
						amount_Loan = Convert.ToDouble(amountLoan_TB.Text);
						IAmount = String.Format("{0:C}", amount_Loan);
						amountLoan_TB.Text = Convert.ToString(IAmount);
						}
				}else if(!amountLoan_TB.Text.Contains("$")){
						amount_Loan = Convert.ToDouble(amountLoan_TB.Text);
						number_Year = Convert.ToDouble(numberYear_TB.Text);
						interest_Rate = Convert.ToDouble(interestRate_TB.Text);
						interestMonthly_Rate = interest_Rate / 1200;
		
						//Monthly Payment equation
						MonthlyPayment = amount_Loan * interestMonthly_Rate / (1 - 1 / Math.Pow(1 + interestMonthly_Rate, number_Year * 12));
		
						iMonthlyPayment = Convert.ToString(MonthlyPayment);
						iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
						monthlyPay_LB.Text = Convert.ToString(iMonthlyPayment);
		
						//Total Payment equation
						TotalOfPayment = MonthlyPayment * number_Year * 12;
		
						ITotalPayment = Convert.ToString(TotalOfPayment);
						ITotalPayment = String.Format("{0:C}", TotalOfPayment);
						totalPay_LB.Text = Convert.ToString(ITotalPayment);
									
						amount_Loan = Convert.ToDouble(amountLoan_TB.Text);
						IAmount = String.Format("{0:C}", amount_Loan);
						amountLoan_TB.Text = Convert.ToString(IAmount);
				}
		}
	}
		//Add Function on Main Form
		public static void AddBtnFunction(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label account_IDLB, DataGridView Data, TextBox seachName_TB) {
			//CHECK IF THE TEXT BOX IS EMPTY		
			if (amountLoan_TB.Text.Equals("") || numberYear_TB.Text.Equals("")  || interestRate_TB.Text.Equals("")  || firstName_TB.Text.Equals("")  || middleName_TB.Text.Equals("")  ||lastName_TB.Text.Equals("")) {
				MessageBox.Show("Please fill up all the fields!!");
			} else {
				Calculate(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB);
				
				Add(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, Data, seachName_TB);
				
				//Refresh the data by loading again
				LoadTable(Data);
				//Clear all Text box
				Clear(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, seachName_TB);
	
				MessageBox.Show("The Loan has been added......");
			}
		}
		//Updates Function on Main Form
		public static void UpdatesBtnFunction(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label accountID_LB, DataGridView Data, TextBox seachName_TB) {
			//CHECK IF THE TEXT BOX IS EMPTY		
			if (amountLoan_TB.Text.Equals("") || numberYear_TB.Text.Equals("")  || interestRate_TB.Text.Equals("")  || firstName_TB.Text.Equals("")  || middleName_TB.Text.Equals("")  ||lastName_TB.Text.Equals("")) {
				MessageBox.Show("Please fill up all the fields!!");
			} else {
			Calculate(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB);		
			
			Connect(); //Data Connection for the Access Path
		
			cmd = new MySqlCommand("UPDATE loantable SET LoanAmount=@LoanAmount, NumberOfYear=@NumberOfYear, InterestRate=@InterestRate, MonthlyPayment=@MonthlyPayment, TotalPayment= @TotalPayment WHERE LoanID = @LoanID", con);
	
			// Bind data to the parameters
			cmd.Parameters.AddWithValue("LoanAmount", amountLoan_TB.Text);
			cmd.Parameters.AddWithValue("NumberOfYear", numberYear_TB.Text);
			cmd.Parameters.AddWithValue("InterestRate", interestRate_TB.Text);
			cmd.Parameters.AddWithValue("MonthlyPayment", monthlyPay_LB.Text);
			cmd.Parameters.AddWithValue("TotalPayment", totalPay_LB.Text);
			cmd.Parameters.AddWithValue("LoanID", accountID_LB.Text);
			cmd.ExecuteNonQuery();	
			
			cmd = new MySqlCommand("UPDATE costumers SET Firstname=@Firstname, Middlename= @Middlename, Lastname= @Lastname, Address= @Address  WHERE CostumersID=@CostumersID", con);
			
			// Bind data to the parameters
			cmd.Parameters.AddWithValue("Firstname", firstName_TB.Text);
			cmd.Parameters.AddWithValue("Middlename", middleName_TB.Text);
			cmd.Parameters.AddWithValue("Lastname", lastName_TB.Text);
			cmd.Parameters.AddWithValue("Address", acconAddress_TB.Text);
			cmd.Parameters.AddWithValue("CostumersID", accountID_LB.Text);

			cmd.ExecuteNonQuery();
			Disconnect();
			
			//Refresh the data by loading again
			LoadTable(Data);
			//Clear all Text box
			Clear(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, accountID_LB, seachName_TB);

			MessageBox.Show("The Loan has been Updated......");
			}
		}
		//Delete The function in Main Form
		public static void DeleteBtnFunction(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label accountID_LB, Label loginUser_LB, Label account_IDLB, DataGridView Data, TextBox seachName_TB) {
			//Confirmation Message
			DialogResult iDelete;
			iDelete = MessageBox.Show("Confirm if you want to Delete", "Loan Management System", MessageBoxButtons.YesNo);

			//Checking the user want to delete
			if (iDelete == DialogResult.Yes) {
				//CHECK IF THE TEXT BOX IS EMPTY		
				if (amountLoan_TB.Text.Equals("") || numberYear_TB.Text.Equals("")  || interestRate_TB.Text.Equals("")  || firstName_TB.Text.Equals("")  || middleName_TB.Text.Equals("")  ||lastName_TB.Text.Equals("") || accountID_LB.Text.Equals("")) {
					MessageBox.Show("Please fill up all the fields!!");
				} else {
					Add(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, Data, seachName_TB, loginUser_LB);
		
					Connect();
		
					cmd = new MySqlCommand("DELETE FROM loantable WHERE LoanID=@LoanID", con);
					cmd.Parameters.AddWithValue("LoanID", accountID_LB.Text);
					cmd.ExecuteNonQuery();
					
					cmd = new MySqlCommand("DELETE FROM costumers WHERE CostumersID=@CostumersID", con);
					cmd.Parameters.AddWithValue("CostumersID", accountID_LB.Text);
					cmd.ExecuteNonQuery();
					Disconnect();
					
					//Refresh the data by loading again
					LoadTable(Data);
					//Clear all Text box
					Clear(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, seachName_TB);
	
				MessageBox.Show("The Loan has been Deleted......");
				}
			}
		}
		//Data from the database
		public static void DataGridView(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label account_IDLB, DataGridView Data, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0){
				DataGridViewRow rows = Data.Rows[e.RowIndex]; //Select a Row in Data Table
				account_IDLB.Text = rows.Cells["Costumers ID"].Value.ToString();
				amountLoan_TB.Text = rows.Cells["Loan Amount"].Value.ToString();
				numberYear_TB.Text = rows.Cells["Number Of Year"].Value.ToString();
				interestRate_TB.Text = rows.Cells["Interest Rate"].Value.ToString();
				monthlyPay_LB.Text = rows.Cells["Monthly Payment"].Value.ToString();
				totalPay_LB.Text = rows.Cells["Total Payment"].Value.ToString();
				firstName_TB.Text = rows.Cells["Firstname"].Value.ToString();
				middleName_TB.Text = rows.Cells["Middle Name"].Value.ToString();
				lastName_TB.Text = rows.Cells["Lastname"].Value.ToString();
				acconAddress_TB.Text = rows.Cells["Address of Costomers"].Value.ToString();
			} else {
				MessageBox.Show("No Data Found");
			};
		}	
		//Datatable of GridView		
		public static void LoadTable(DataGridView Data, String search = "") {
			DataTable dt = new DataTable();

			dt.Columns.Add("Firstname");
			dt.Columns.Add("Middle Name");
			dt.Columns.Add("Lastname");
			dt.Columns.Add("Costumers ID");
			dt.Columns.Add("Loan Amount");
			dt.Columns.Add("Number Of Year");
			dt.Columns.Add("Interest Rate");
			dt.Columns.Add("Monthly Payment");
			dt.Columns.Add("Total Payment");
			dt.Columns.Add("Address of Costomers");

			Connect();
			if(search.Equals("")){
				cmd = new MySqlCommand("SELECT DISTINCT costumers.CostumersID, costumers.Firstname, costumers.Middlename, costumers.Lastname, costumers.Address, " +
			                       "loantable.LoanAmount, loantable.NumberOfYear,loantable.InterestRate, loantable.MonthlyPayment, loantable.TotalPayment " +
			                       "FROM costumers, loantable WHERE loantable.LoanID = costumers.LoanID ORDER BY costumers.CostumersID", con);
			
			}else{
				cmd = new MySqlCommand("SELECT DISTINCT costumers.CostumersID, costumers.Firstname, costumers.Middlename, costumers.Lastname, costumers.Address, " +
			                       "loantable.LoanAmount, loantable.NumberOfYear,loantable.InterestRate, loantable.MonthlyPayment, loantable.TotalPayment " +
			                       "FROM costumers, loantable WHERE loantable.LoanID = costumers.LoanID AND ( Firstname LIKE @search OR Lastname LIKE @search )", con);
				
				cmd.Parameters.AddWithValue("search", search + "%");
			}
			
			dr = cmd.ExecuteReader();
			
			while (dr.Read()) {
				dt.Rows.Add(dr["Firstname"].ToString(), dr["MiddleName"].ToString(), dr["LastName"].ToString(), Convert.ToInt32(dr["CostumersID"]),
	            dr["LoanAmount"].ToString(), dr["NumberOfYear"].ToString(), dr["InterestRate"].ToString(), dr["MonthlyPayment"].ToString(),
	            dr["TotalPayment"].ToString(), dr["Address"].ToString());
			}

			Disconnect();
			Data.DataSource = dt;
		}
		//Delete Loans
		public static void DeleteLoans(DataGridView Data, String search = "") {
			//Delete Loans
			DataTable dt = new DataTable();
			dt.Columns.Add("Firstname");
			dt.Columns.Add("Middle Name");
			dt.Columns.Add("Lastname");
			dt.Columns.Add("Costumers ID");
			dt.Columns.Add("Loan Amount");
			dt.Columns.Add("Number Of Year");
			dt.Columns.Add("Interest Rate");
			dt.Columns.Add("Monthly Payment");
			dt.Columns.Add("Total Payment");
			dt.Columns.Add("Address of Costomers");
			dt.Columns.Add("Deleted By");

			Connect();
			cmd = new MySqlCommand("Select * FROM deletedatatable WHERE Firstname LIKE @search OR LastName LIKE @search", con);
			cmd.Parameters.AddWithValue("search", search + "%");
			dr = cmd.ExecuteReader();

			while (dr.Read()) {
				dt.Rows.Add(dr["Firstname"].ToString(), dr["MiddleName"].ToString(), dr["LastName"].ToString(),
	            Convert.ToInt32(dr["CostumersID"]), dr["LoanAmount"].ToString(), dr["NumberOfYear"].ToString(),
	            dr["InterestRate"].ToString(), dr["MonthlyPayment"].ToString(), dr["TotalPayment"].ToString(),
	            dr["Address"].ToString(), dr["DeletedBy"].ToString());
			}

			Disconnect();

			Data.DataSource = dt;
		}
		//Clear All Text Box
		public static void Clear(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label account_IDLB, TextBox seachName_TB) {
			amountLoan_TB.Text = "";
			numberYear_TB.Text = "";
			interestRate_TB.Text = "";
			monthlyPay_LB.Text = "";
			totalPay_LB.Text = "";
			firstName_TB.Text = "";
			middleName_TB.Text = "";
			lastName_TB.Text = "";
			acconAddress_TB.Text = "";
			account_IDLB.Text = "";
			seachName_TB.Text = "";
		}
		//Generate Receipt Button
		public static void Generate(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB) {
			//Checking if the textbox is Empty
			if (amountLoan_TB.Text != "" && numberYear_TB.Text != "" && interestRate_TB.Text != "" && monthlyPay_LB.Text != "" && totalPay_LB.Text != "") {
				//Receipt Result using Message Box
				DialogResult iReceipt;
				//Receipty Message
				iReceipt = MessageBox.Show("Loan Management System Calculator" + "\n" + "-----------------------------------------------------------------------------" + "\n" +
				                           "Enter Amount of Loan: " + "\t" + amountLoan_TB.Text + "\n" + "Enter Number of Year: " + "\t" + numberYear_TB.Text + "\n" + "Enter Interest Rate: " + "\t" + interestRate_TB.Text + "\n" +
				                           "Monthly Payment: " + "\t" + "\t" + monthlyPay_LB.Text + "\n" + "Total Payment: " + "\t" + "\t" + totalPay_LB.Text + "\n" +
				                           "------------------------------------------------------------------------------" + "\n" + "Name: " +
				                           firstName_TB.Text + " " + middleName_TB.Text + " " + lastName_TB.Text + "\n" +
				                           "Address: " + acconAddress_TB.Text + "\n" + "------------------------------------------------------------------------------" +
				                           "\n" + "------------------------------------Thank you-----------------------------" + "\n", "Receipt", MessageBoxButtons.OKCancel);

				if (iReceipt == DialogResult.OK) {
					MessageBox.Show("The Receipt has been added to Process");
				}
			} else {
				MessageBox.Show("No data Found");
			};
		}
		//Exit Button
		public static void Exit() {
			//Confirmation Message
			DialogResult iExit;
			iExit = MessageBox.Show("Confirm if you want to exit", "Loan Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			//Checking if the user want to Exit
			if (iExit == DialogResult.Yes) {
				Application.Exit();
			}
		}
		//Add Function on Main Form
		public static void Add(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label account_IDLB, DataGridView Data, TextBox seachName_TB) {
				Connect();//Data Connection for the Access Path
	
				cmd = new MySqlCommand("INSERT INTO loantable (LoanAmount, NumberOfYear, InterestRate, MonthlyPayment, TotalPayment) VALUES (@LoanAmount, @NumberOfYear, @InterestRate, @MonthlyPayment, @TotalPayment)", con);
		
				// Bind data to the parameters
				cmd.Parameters.AddWithValue("LoanAmount", amountLoan_TB.Text);
				cmd.Parameters.AddWithValue("NumberOfYear", numberYear_TB.Text);
				cmd.Parameters.AddWithValue("InterestRate", interestRate_TB.Text);
				cmd.Parameters.AddWithValue("MonthlyPayment", monthlyPay_LB.Text);
				cmd.Parameters.AddWithValue("TotalPayment", totalPay_LB.Text);
				cmd.ExecuteNonQuery();
				
				// start to get the last id
				cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", con);
				dr = cmd.ExecuteReader();
				dr.Read(); // go to first row
				int loanID = Convert.ToInt32(dr[0]);
				dr.Close(); 
				
				cmd = new MySqlCommand("INSERT INTO costumers (Firstname, Middlename, Lastname, Address, LoanID) VALUES (@Firstname, @Middlename, @Lastname, @Address, @LoanID)", con);
				
				// Bind data to the parameters
				cmd.Parameters.AddWithValue("Firstname", firstName_TB.Text);
				cmd.Parameters.AddWithValue("Middlename", middleName_TB.Text);
				cmd.Parameters.AddWithValue("Lastname", lastName_TB.Text);
				cmd.Parameters.AddWithValue("Address", acconAddress_TB.Text);
				cmd.Parameters.AddWithValue("LoanID", loanID);
	
				cmd.ExecuteNonQuery();
				Disconnect();
				
				//Clear all Text box
				Clear(amountLoan_TB, numberYear_TB, interestRate_TB, monthlyPay_LB, totalPay_LB, firstName_TB, middleName_TB, lastName_TB, acconAddress_TB, account_IDLB, seachName_TB);
		}
		//Add Delete Function on Main Form
		public static void Add(TextBox amountLoan_TB, TextBox numberYear_TB, TextBox interestRate_TB, Label monthlyPay_LB, Label totalPay_LB, TextBox firstName_TB, TextBox middleName_TB, TextBox lastName_TB, TextBox acconAddress_TB, Label account_IDLB, DataGridView Data, TextBox seachName_TB, Label loginUser_LB) {
		
				Connect(); //Open Connectioon and Delete the data on database
		
				cmd = new MySqlCommand("INSERT INTO deletedatatable (CostumersID, LoanAmount, NumberOfYear, InterestRate, MonthlyPayment," +
										  "TotalPayment, FirstName, MiddleName, LastName, Address, DeletedBy) " + "VALUES (@CostumersID, @LoanAmount," +
										  "@NumberOfYear, @InterestRate, @MonthlyPayment, @TotalPayment, @FirstName, @MiddleName, @LastName, @Address, @DeletedBy)", con);
	
				// Bind data to the parameters
				cmd.Parameters.AddWithValue("CostumersID", account_IDLB.Text);
				cmd.Parameters.AddWithValue("LoanAmount", amountLoan_TB.Text);
				cmd.Parameters.AddWithValue("NumberOfYear", numberYear_TB.Text);
				cmd.Parameters.AddWithValue("InterestRate", interestRate_TB.Text);
				cmd.Parameters.AddWithValue("MonthlyPayment", monthlyPay_LB.Text);
				cmd.Parameters.AddWithValue("TotalPayment", totalPay_LB.Text);
				cmd.Parameters.AddWithValue("FirstName", firstName_TB.Text);
				cmd.Parameters.AddWithValue("MiddleName", middleName_TB.Text);
				cmd.Parameters.AddWithValue("LastName", lastName_TB.Text);
				cmd.Parameters.AddWithValue("Address", acconAddress_TB.Text);
				cmd.Parameters.AddWithValue("DeletedBy", loginUser_LB.Text);
	
				cmd.ExecuteNonQuery();
				Disconnect();
		}
	}
}