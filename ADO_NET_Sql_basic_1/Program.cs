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
            Console.WriteLine("Table " + tableName + " was created.\n");
            conn.Close();
        }catch(Exception e)
        {
            Console.WriteLine(e);
        }

    }

    public void insertToTable(string tableName, string connstr, int id, string name, string email)
    {
        SqlConnection conn;
        try
        {
            conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("insert into " + tableName + "(Id, Name, email)values("+id+",'" + name + "','" + email + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data was inserted successfully.\n");
            conn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }


    public void deleteDataAccordingId(string tableName, string connstr, int id)
    {
        SqlConnection conn;
        try
        {
            conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("delete from " + tableName + " where id = '"+id+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data was delete successfully.\n");
            conn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void printTableData(string tableName, string connstr)
    {
        SqlConnection conn;
        int rowCount = 0;
        try
        {
            conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand("select COUNT(*) from " + tableName, conn);
            conn.Open();
            rowCount = (int)cmd.ExecuteScalar();
            SqlCommand cmdRead = new SqlCommand("select *from " + tableName, conn);
            SqlDataReader reader = cmdRead.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + " " +reader["Name"]+ " " + reader["email"]);
            }

            conn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }



    static void Main(string[] args)
        {
        Program mainObj = new Program();
        //mainObj.createTable("TestTable", mainObj.connString);
        //mainObj.deleteDataAccordingId("TestTable", mainObj.connString, 3);
        //mainObj.deleteDataAccordingId("TestTable", mainObj.connString, 2);
        //mainObj.insertToTable("TestTable", mainObj.connString, 2, "AAAA", "nasjjdhsaj");
        //mainObj.insertToTable("TestTable", mainObj.connString, 3, "BBBB", "nasjjdhsaj");
        mainObj.printTableData("TestTable", mainObj.connString);
        Console.WriteLine("Hello Peter Kubala is program in ADO.NET.");
        }
    }
