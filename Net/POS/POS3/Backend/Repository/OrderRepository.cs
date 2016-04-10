using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS3.Repository
{
    class OrderRepository
    {/*
      public void findAll()
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");

            SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from Customers", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the CustomerID of each record
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
    }

        public void insert()
        {
            // prepare command string
            string insertString = @"
            insert into Categories
            (CategoryName, Description)
            values ('Miscellaneous', 'Whatever doesn''t fit elsewhere')";

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString, conn);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }

        public void update()
        {
            // prepare command string
            string updateString = @"
            update Categories
            set CategoryName = 'Other'
            where CategoryName = 'Miscellaneous'";

            // 1. Instantiate a new command with command text only
            SqlCommand cmd = new SqlCommand(updateString);

            // 2. Set the Connection property
            cmd.Connection = conn;

            // 3. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            // prepare command string
            string deleteString = @"
     delete from Categories
     where CategoryName = 'Other'";

            // 1. Instantiate a new command
            SqlCommand cmd = new SqlCommand();

            // 2. Set the CommandText property
            cmd.CommandText = deleteString;

            // 3. Set the Connection property
            cmd.Connection = conn;

            // 4. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }
        */
    }
}