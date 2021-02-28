
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loan_Management_System
{
	/// <summary>
	/// Description of Database.
	/// </summary>
	public class Database
	{
		public static MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=loansystemdb");
		public static MySqlCommand cmd;
		public static MySqlDataReader dr;
		
		/// <summary>
		/// Connects to the mysql database
		/// </summary>
		public static void Connect() 
		{
			if (con.State != ConnectionState.Open) 
			{
				con.Open();
			}
		}
		
		/// <summary>
		/// Disconnects to the mysql database
		/// </summary>
		public static void Disconnect() 
		{
			if (con.State != ConnectionState.Closed) 
			{
				con.Close();
			}
		}
	}
}
