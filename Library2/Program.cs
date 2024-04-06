using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
	class Program
	{
		static void Main(string[] args)
		{
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;
										 Initial Catalog=LibraryPD_321;
										 Integrated Security=True;Connect Timeout=30;
										 Encrypt=False;
										 TrustServerCertificate=False;
										 ApplicationIntent=ReadWrite;
										 MultiSubnetFailover=False";
			Library library = new Library(connection_string);
			library.InsertAuthor("Abercrombie", "Joe");
			library.SelectAuthors();
			library.SelectBooks("Abercrombie", "Joe");
			library.InsertBook("The King", "Joe","Abercrombie",  65 , 180 );
		}
	}
}
