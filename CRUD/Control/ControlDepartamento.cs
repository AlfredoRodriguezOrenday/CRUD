using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD.Modelo;

namespace CRUD.Control
{
    internal class ControlDepartamento
    {
        Connection ConnectionDB;
        SqlCommand Query;

        public ControlDepartamento()
        {
            ConnectionDB = new Connection();
        }

        public void Add(Departamento ObjDepartamento)
        {
            Query = new SqlCommand("Insert Into Departamento Values(@Clave, @Nombre, @Estatus)");
            Query.Parameters.Add("@Clave", SqlDbType.VarChar).Value = ObjDepartamento.Clave;
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjDepartamento.Nombre;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjDepartamento.Estatus;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void Update(Departamento ObjDepartamento)
        {
            Query = new SqlCommand("UPDATE Departamento SET Nombre = @Nombre, Estatus = @Estatus WHERE Clave = @Clave");
            Query.Parameters.Add("@Clave", SqlDbType.VarChar).Value = ObjDepartamento.Clave;
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjDepartamento.Nombre;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjDepartamento.Estatus;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void Delete(Departamento ObjDepartamento)
        {
            Query = new SqlCommand("Update Departamento SET Estatus = 'Inactivo' WHERE Clave = @Clave");
            Query.Parameters.Add("@Clave", SqlDbType.VarChar).Value = ObjDepartamento.Clave;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public DataSet ShowDepartamentos()
        {
            Query = new SqlCommand("SELECT * FROM Departamento WHERE Estatus = 'Activo'");
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }
    }
}
