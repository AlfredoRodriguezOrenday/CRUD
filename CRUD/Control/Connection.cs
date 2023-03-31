using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CRUD.Control
{
    public class Connection
    {
        SqlConnection ConnectionDB;
        string StringConnection = "server= LAPTOP-3989L6UR; database= dbExamenTI; integrated security = true";

        public SqlConnection SetConnection()
        {
            return ConnectionDB = new SqlConnection(StringConnection);
        }

        public void ExecuteQueryWithOutReturnData(SqlCommand SQLCommand)
        {
            try
            {
                SqlCommand Command = SQLCommand;
                Command.Connection = this.SetConnection();
                ConnectionDB.Open();
                Command.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show("Fallo el query " + ex.Message);
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

        public DataSet ExecuteQueryWithReturnData(SqlCommand SQLCommand)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            try
            {
                SqlCommand Command = SQLCommand;
                Command.Connection = this.SetConnection();
                Adapter.SelectCommand = Command;
                ConnectionDB.Open();
                Adapter.Fill(DS);
                return DS;
            }
            catch(Exception ex)
            {
                MessageBox.Show("El query fallo " + ex.Message);
                return DS;
            }
            finally
            {
                ConnectionDB.Close();
            }
        }

    }
}
