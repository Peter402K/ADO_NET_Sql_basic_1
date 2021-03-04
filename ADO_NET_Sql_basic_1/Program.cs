using System;
using System.Data.SqlClient;


    class Program
    {

    public string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kubal\\Documents\\Visual Studio 2015\\Projects\\Git_project\\ADO_NET_Sql_basic_1\\ADO_NET_Sql_basic_1\\TestDatabase.mdf;Integrated Security=True";

    public void createTable(string tableName, string connstr)
    {
        SqlConnection conn;
        try
        {
            conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("create table " + tableName + "(Id int not null, Name varchar(50), email varchar(50))", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table " + tableName + " was created.");
            conn.Close();
        }catch(Exception e)
        {
            Console.WriteLine(e);
        }

    }





        static void Main(string[] args)
        {
        Program mainObj = new Program();
        mainObj.createTable("TestTable", mainObj.connString);
        Console.WriteLine("Hello Peter Kubala in ADO.NET.");
        }
    }
