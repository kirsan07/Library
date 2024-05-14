using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library2
{
	class Library
	{
		string connectionString;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		public Library() : this(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString)
		{
			//connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			//connection = new SqlConnection(connectionString);
			Console.WriteLine(connectionString);
		}
		public Library(string connectionString)
		{
			this.connectionString = connectionString;
			connection = new SqlConnection(connectionString);
		}
		~Library()
		{
			connection.Close();
		}
		public void InsertAuthor(string last_name, string first_name)
		{
			try
			{
				connection.Open();
				string command = $@"
					IF NOT EXISTS 
					(
						SELECT author_id FROM Authors 
						WHERE last_name=@paramLastName 
						AND first_name=@paramFirstName
					)
					BEGIN
							INSERT INTO Authors
									(last_name, first_name)
							VALUES
									(@paramLastName, @paramFirstName)
					END";
				cmd = new SqlCommand(command, connection);
				///---------------------------------------------------------------------------------------------
				//SqlParameter parameterLastName = new SqlParameter("paramLastName", SqlDbType.NVarChar);
				//SqlParameter parameterFirstName = new SqlParameter("paramFirstName", SqlDbType.NVarChar);
				//parameterLastName.Value = last_name;
				//parameterFirstName.Value = first_name;
				//cmd.Parameters.Add(parameterLastName);
				//cmd.Parameters.Add(parameterFirstName);
				///---------------------------------------------------------------------------------------------
				//SqlParameter[] values = new SqlParameter[]
				//	{
				//		new SqlParameter("paramLastName", last_name),
				//		new SqlParameter("paramFirstName", first_name),
				//	};
				//cmd.Parameters.AddRange(values);
				cmd.Parameters.AddWithValue("paramLastName", last_name);
				cmd.Parameters.AddWithValue("paramFirstName", first_name);
				cmd.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void SelectAuthors()
		{
			try
			{
				connection.Open();
				string command = "SELECT * FROM Authors";
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).PadRight(10)} {reader.GetName(1).PadRight(15)} {reader.GetName(2).PadRight(15)}");
				while (reader.Read())
				{
					Console.WriteLine($" {reader[0].ToString().PadRight(10)}  {reader[1].ToString().PadRight(15)}  {reader[2].ToString().PadRight(15)}");
				}
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
		public void SelectBooks()
		{
			try
			{
				connection.Open();
				string command = $@"SELECT 
											title AS Title,
											[Author] = FORMATMESSAGE('%s %s', first_name, last_name)
									FROM Books 
									JOIN Authors ON author=author_id";
				cmd = new SqlCommand(command, connection);
				SqlDataReader reader = cmd.ExecuteReader();
				Console.WriteLine($"{reader.GetName(0).ToString().PadRight(32)} {reader.GetName(1).ToString().PadRight(32)}");
				while (reader.Read())
				{
					Console.WriteLine($"{reader[0].ToString().PadRight(32)} {reader[1].ToString().PadRight(32)}");
				}
			}
			finally
			{
				if (connection != null) connection.Close();
			}
		}
	}
}

