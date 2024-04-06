using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
	class Program
	{
		static void Main(string[] args)
		{
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;
										 Initial Catalog=LibraryPD_321;
										 Integrated Security=True;
										 Connect Timeout=30;
										 Encrypt=False;
										 TrustServerCertificate=False;
										 ApplicationIntent=ReadWrite;
										 MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();

			//Вставка:
			string insert_string = @"INSERT INTO Authors (first_name, last_name) VALUES('Grady', 'Booch')";
			SqlCommand cmd = new SqlCommand(insert_string, connection);
			//cmd.ExecuteNonQuery();

			//Выборка данных:
			string last_name = "'Camaron'";
			string select_condition = "";//$"WHERE author = (SELECT author_id FROM Authors WHERE last_name = {last_name})";
			string select_string = $@"SELECT * FROM Books {select_condition};
									 SELECT SUM(price) FROM Books;";
			cmd.CommandText = select_string;

			SqlDataReader reader = cmd.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i) + "\t");
				if (reader.GetName(i) == "title") Console.Write("".PadRight(24));
			}
			Console.WriteLine();
			//double totalPrice = 0;
			while (reader.Read())
			{
				//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
				for (int i = 0; i < reader.FieldCount; i++)
				{
					if (reader.GetName(i) == "title") Console.Write(reader[i].ToString().PadRight(32));
					else Console.Write(reader[i] + "\t");
				}
				Console.WriteLine();
				//totalPrice += Convert.ToDouble(reader["price"]);
			}
			//Console.WriteLine($"Общая стоимоть всех книг:\t${totalPrice}");
			reader.NextResult();
			reader.Read();
			Console.WriteLine($"Общая стоимоть всех книг:\t${reader[0]}");
			Console.WriteLine();
			reader.Close();

			last_name = "'Cameron'";
			select_condition = $"WHERE author = (SELECT author_id FROM Authors WHERE last_name = {last_name})";
			select_string = $@"SELECT * FROM Books {select_condition};
									 SELECT SUM(price) FROM Books;";
			Console.WriteLine("James Cameron books:");
			cmd.CommandText = select_string;//" WHERE author = (SELECT author_id FROM Authors WHERE last_name='Cameron')";
			double totalPriceCameron = 0;
			reader = cmd.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i) + "\t");
				if (reader.GetName(i) == "title") Console.Write("".PadRight(24));
			}
			Console.WriteLine();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; i++)
				{
					if (reader.GetName(i) == "title") Console.Write(reader[i].ToString().PadRight(32));
					else Console.Write(reader[i] + "\t");
					if (reader.GetName(i) == "price") totalPriceCameron += Convert.ToDouble(reader[i]);
				}
				Console.WriteLine();
			}
			Console.WriteLine($"Cameron total price: {totalPriceCameron}");
			connection.Close();
		}
	}
}
