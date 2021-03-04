using System;
using System.Data.SqlClient;


    class Program
    {

    public string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kubal\\Documents\\Visual Studio 2015\\Projects\\Git_project\\ADO_NET_Sql_basic_1\\ADO_NET_Sql_basic_1\\TestDatabase.mdf;Integrated Security=True";
        static void Main(string[] args)
        {

        using (SqlConnection sqlcon = new SqlConnection((new Program()).connString))
        {
            sqlcon.Open();
            sqlcon.Close();
        }

        Console.WriteLine("Hello Peter Kubala in ADO.NET.");
        }
    }
