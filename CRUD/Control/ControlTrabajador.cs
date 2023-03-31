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
    internal class ControlTrabajador
    {
        Connection ConnectionDB;
        SqlCommand Query;
        public ControlTrabajador()
        {
            ConnectionDB = new Connection();
        }
        public void Add(Trabajador ObjTrabajador)
        {
            Query = new SqlCommand("EXEC SP_SaveTrabajadorWithOutDepartamentO @Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus");
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            Query.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = ObjTrabajador.Apellidos;
            Query.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = ObjTrabajador.FechaNcimiento;
            Query.Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = ObjTrabajador.FechaContratacion;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjTrabajador.Estatus;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void Add(Trabajador ObjTrabajador, Relaciones ObjRelacion)
        {
            Query = new SqlCommand("EXEC SP_SaveTrabajadorWithDepartamento @Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus, @FkDepartamento");
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            Query.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = ObjTrabajador.Apellidos;
            Query.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = ObjTrabajador.FechaNcimiento;
            Query.Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = ObjTrabajador.FechaContratacion;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjTrabajador.Estatus;
            Query.Parameters.Add("@FkDepartamento", SqlDbType.VarChar).Value = ObjRelacion.FkDepartamento;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void Update(Trabajador ObjTrabajador)
        {
            Query = new SqlCommand("EXEC SP_UpdateTrabajadorWithOutDepartamento @ID, @Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = ObjTrabajador.ID;
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            Query.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = ObjTrabajador.Apellidos;
            Query.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = ObjTrabajador.FechaNcimiento;
            Query.Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = ObjTrabajador.FechaContratacion;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjTrabajador.Estatus;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void Update(Trabajador ObjTrabajador, Relaciones ObjRelacion)
        {
            Query = new SqlCommand("EXEC SP_UpdateTrabajadorWithDepartamento @ID, @Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus, @FkDepartamento");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = ObjTrabajador.ID;
            Query.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            Query.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = ObjTrabajador.Apellidos;
            Query.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = ObjTrabajador.FechaNcimiento;
            Query.Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = ObjTrabajador.FechaContratacion;
            Query.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = ObjTrabajador.Estatus;
            Query.Parameters.Add("@FkDepartamento", SqlDbType.VarChar).Value = ObjRelacion.FkDepartamento;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public void  Delete(Trabajador ObjTrabajador)
        {
            Query = new SqlCommand("UPDATE Trabajador SET Estatus = 'Inactivo' WHERE IdTrabajador = @ID");
            Query.Parameters.Add("@ID", SqlDbType.Int).Value = ObjTrabajador.ID;
            ConnectionDB.ExecuteQueryWithOutReturnData(Query);
        }

        public DataSet ShowTrabajadores(string ObjQuery)
        {
            Query = new SqlCommand(ObjQuery);
            return ConnectionDB.ExecuteQueryWithReturnData(Query);
        }
    }
}
