using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Modelo;
using CRUD.Control;

namespace CRUD.View
{
    public partial class ViewTrabajador : Form
    {
        ControlTrabajador CntrlTrabajador;
        private string Query;
        public ViewTrabajador()
        {
            InitializeComponent();
            CntrlTrabajador = new ControlTrabajador();
            ShowTrabajadores();
            ShowDepartamentos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (IsReadyTextBox())
            {
                Relaciones relaciones = GetInfoRelaciones();
                if ( relaciones.FkDepartamento == "")
                {
                    CntrlTrabajador.Add(GetInfoTrabajador());
                }
                else if(relaciones.FkDepartamento != "")
                {
                    
                    CntrlTrabajador.Add(GetInfoTrabajador(), relaciones);
                }
            }
            ShowTrabajadores();
            CleanText();
        }
        private Trabajador GetInfoTrabajador()
        {
            Trabajador TrabajadorM = new Trabajador();
            int Id = 0;
            int.TryParse(txtID.Text, out Id);
            TrabajadorM.ID = Id;
            TrabajadorM.Nombre = txtNombre.Text;
            TrabajadorM.Apellidos = txtApellidos.Text;
            TrabajadorM.FechaNcimiento = DateFormat(DTFechaNacimiento.Text);
            TrabajadorM.FechaContratacion = DateFormat(DTFechaContratacion.Text);
            TrabajadorM.Estatus = CBEstatus.Text;

            return TrabajadorM;
        }

        private Relaciones GetInfoRelaciones()
        {
            Relaciones relacion = new Relaciones();
            int id = 0;
            
                if (cbxClaveDepartamento.SelectedIndex != -1)
                {
                    relacion.FkDepartamento = cbxClaveDepartamento.SelectedValue.ToString();
                    relacion.FkTrabajador = id;
                MessageBox.Show(relacion.FkDepartamento + " relaciones si " + relacion.FkTrabajador);
                }
                else
                {
                    relacion.FkDepartamento = "";
                }
            MessageBox.Show(relacion.FkDepartamento + " relaciones " + relacion.FkTrabajador);
            return relacion;
        }
        private string DateFormat(string DatesA)
        {
            DateTime Fecha = new DateTime();
            Fecha = Convert.ToDateTime(DatesA);
            string fechas = Fecha.ToString("yyyy-MM-dd");

            return fechas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (IsReadyTextBox())
            {
                Relaciones relaciones = GetInfoRelaciones();
                if (relaciones.FkDepartamento == "")
                {
                    CntrlTrabajador.Update(GetInfoTrabajador());
                }
                else if (relaciones.FkDepartamento != "")
                {
                    CntrlTrabajador.Update(GetInfoTrabajador(), relaciones);
                }
            }

            ShowTrabajadores();
            CleanText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IsReadyTextBox())
            {
                CntrlTrabajador.Delete(GetInfoTrabajador());
                ShowTrabajadores();
                CleanText();
            }
        }

        private void ShowTrabajadores()
        {
            if (CheckDepartamentos.Checked)
            {
                Query = "SELECT T.*, R.FkDepartamento, D.Nombre FROM Trabajador AS T, Relaciones AS R, Departamento AS D WHERE T.Estatus = 'Activo' and T.IdTrabajador = R.FkTrabajador and D.Clave = R.FkDepartamento";                
            }
            else
            {
                Query = "SELECT * FROM Trabajador WHERE Estatus = 'Activo'";
                
            }
            DGVTrabajadores.DataSource = CntrlTrabajador.ShowTrabajadores(Query).Tables[0];
            DGVTrabajadores.Columns[0].HeaderText = "Id";
            DGVTrabajadores.Columns[1].HeaderText = "Nombres";
            DGVTrabajadores.Columns[2].HeaderText = "Apellidos";
            DGVTrabajadores.Columns[3].HeaderText = "Fecha Nacimiento";
            DGVTrabajadores.Columns[4].HeaderText = "Fecha Contratacion";
            DGVTrabajadores.Columns[5].HeaderText = "Estatus";
            if (DGVTrabajadores.ColumnCount > 6)
            {
                DGVTrabajadores.Columns[6].HeaderText = "Clave Departamento";
                DGVTrabajadores.Columns[7].HeaderText = "Nombre Departamento";
            }
        }

        private void ShowDepartamentos()
        {
            Query = "SELECT Clave, Nombre FROM Departamento WHERE Estatus = 'Activo'";
            cbxClaveDepartamento.DataSource = CntrlTrabajador.ShowTrabajadores(Query).Tables[0].DefaultView;
            cbxClaveDepartamento.ValueMember = "Clave";
            cbxClaveDepartamento.DisplayMember = "Nombre";
        }

        private void CleanText()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            DTFechaNacimiento.Value = DateTime.Now;
            DTFechaContratacion.Value = DateTime.Now;
            CBEstatus.SelectedValue = "";
            cbxClaveDepartamento.SelectedIndex = -1;
        }
        private void CheckDepartamentos_CheckedChanged(object sender, EventArgs e)
        {
            ShowTrabajadores();
        }

        private void DGVTrabajadores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DGVTrabajadores.ClearSelection();
            if(index >= 0)
            {
                txtID.Text = DGVTrabajadores.Rows[index].Cells[0].Value.ToString();
                txtNombre.Text = DGVTrabajadores.Rows[index].Cells[1].Value.ToString();
                txtApellidos.Text = DGVTrabajadores.Rows[index].Cells[2].Value.ToString();
                DTFechaNacimiento.Text = DGVTrabajadores.Rows[index].Cells[3].Value.ToString();
                DTFechaContratacion.Text = DGVTrabajadores.Rows[index].Cells[4].Value.ToString();
                CBEstatus.Text = DGVTrabajadores.Rows[index].Cells[5].Value.ToString();
                if(DGVTrabajadores.ColumnCount > 6)
                {
                    cbxClaveDepartamento.SelectedValue = DGVTrabajadores.Rows[index].Cells[6].Value.ToString();
                    cbxClaveDepartamento.DisplayMember = DGVTrabajadores.Rows[index].Cells[7].Value.ToString();
                }
            }
        }

        private bool IsReadyTextBox()
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && CBEstatus.SelectedValue != "")
            {
                if(cbxClaveDepartamento.SelectedValue != "" )
                {
                    return true;
                }
                return true;
            }
            MessageBox.Show("Rellene todos los campos por favor");
            return false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            this.Hide();
            Inicio.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanText();
        }
    }
}
