using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DatabaseConnection
    {
 
//---------------------------------------------Sigleton Pattern-------------------------------------------------------

        //singleton instance 
        private static DatabaseConnection InstanceDB = new DatabaseConnection();
        //methods
        public static DatabaseConnection GetInstance()
        {
            return InstanceDB;
        }
//----------------------------------------------------------------------------------------------------


        //Fields
        private static SqlConnection conn;
        private static SqlDataAdapter adapter;
        //instantiations
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        //contructors
        public DatabaseConnection()
        {
           
            //buildiong connection string
            connection.DataSource = @"LAPTOP-OO78JRT3\SQLEXPRESS";
            connection.InitialCatalog = "MilitaryCommunications";
            connection.IntegratedSecurity = true;

            //setting up connection pipeline
             conn = new SqlConnection(connection.ToString());
             Console.WriteLine(connection.ToString());
            try
            {
                //open connection
              
            }
            catch (SqlException ex)
            {

             
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }












        /*
         Open an close connection
         
         */

        public SqlConnection OpenConnection()
        {
            try
            {
                if ((conn.State != ConnectionState.Open) || (conn.State == ConnectionState.Broken))
                {
                    conn.Open();
                    Console.WriteLine("Connection :"+conn.State.ToString());
                }
            }
            catch (Exception e)
            {

                string error = e.Message;
                Console.WriteLine("Connection OpenConnection :" + error);
            }

            return conn;
        }

        //close connection
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Connection :" + conn.State.ToString());
            }
        }





        //--------------------------------------------------Database CRUD METHOD--------------------------------------------------
        /*
         *Create
         * Read
         * Update
         * Delete
         * 
         */
        //select or Read
        public DataSet SelectFromDataBase(String TableName ,String query)
        {
            DataSet rawdata = new DataSet(TableName);
            DataTable tableData = new DataTable();
            try
            {
                //open connection
                InstanceDB.OpenConnection();
                //insert query on connection pipe
                adapter = new SqlDataAdapter(query, conn);
                adapter.FillSchema(rawdata, SchemaType.Source, TableName);
                adapter.Fill(rawdata, TableName);

              //  adapter.Fill(tableData);

            }
            catch (SqlException ex)
            {

                Console.WriteLine("SelectFromDataBase :" + ex.Message);
            }
            finally
            {
                InstanceDB.CloseConnection();
            }
            return rawdata;
        }

        //insert or Create
        public int InsertDataIntoDatabase(String query)
        {


            int rowsInserted =0;
            try
            {
                //open connection
                InstanceDB.OpenConnection();
                //insert query on connection pipe
                SqlCommand command = new SqlCommand(query, conn);
                rowsInserted = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("InsertDataIntoDatabase :" + ex.Message);
            }
            finally
            {
                InstanceDB.CloseConnection();
            }
            return rowsInserted;
        }

        //delete 
        public int DeleteDataInDatabase(String query)
        {


            int rowsDeleted = 0;
            try
            {
             
                //open connection
                InstanceDB.OpenConnection();
                //insert query on connection pipe
                SqlCommand command = new SqlCommand(query, conn);
                rowsDeleted = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("DeleteintheDatabase :" + ex.Message);
            }
            finally
            {
                InstanceDB.CloseConnection();
            }
            return rowsDeleted;
        }

        //update
        public int  UpdateDataInDatabse(String query)
        {
            int rowsUpdated = 0;
            try
            {
                //open connection
                InstanceDB.OpenConnection();
                SqlCommand command = new SqlCommand(query, conn);
                rowsUpdated= command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
               
                Console.WriteLine("UpdateTableinDatabse Error : "+  ex.Message );
                Console.ForegroundColor = ConsoleColor.Black;
            }
            finally
            {
                InstanceDB.CloseConnection();
            }
            return rowsUpdated;
        }





    }
}
