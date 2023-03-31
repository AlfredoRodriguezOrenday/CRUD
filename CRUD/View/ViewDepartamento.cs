using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUD.Control;
using CRUD.Modelo;

namespace CRUD.View
{
    public partial class ViewDepartamento : Form
    {
        ControlDepartamento CDepartamento;
        Departamento ModeloDepartamento = new Departamento();
        public ViewDepartamento()
        {
            InitializeComponent();
            CDepartamento = new ControlDepartamento();
            ShowDepartamentos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtClave.Text != "" && txtNombre.Text != "" && CBEstatus.Text != "")
            {
                CDepartamento.Add(GetInfo());
                ShowDepartamentos();
                CleanText();
            }
            else
            {
                MessageBox.Show("Por favor relleno todos los campos");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtNombre.Text != "" && CBEstatus.Text != "")
            {
                CDepartamento.Update(GetInfo());
                ShowDepartamentos();
                CleanText();
            }
            else
            {
                MessageBox.Show("Por favor relleno todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != "" && txtNombre.Text != "" && CBEstatus.Text != "")
            {
                CDepartamento.Delete(GetInfo());
                ShowDepartamentos();
                CleanText();
            }
            else
            {
                MessageBox.Show("Por favor relleno todos los campos");
            }
        }

        private void Select(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Index = e.RowIndex;
            DGVDepartamentos.ClearSelection();
            if(Index >= 0)
            {
                txtClave.Text = DGVDepartamentos.Rows[Index].Cells[0].Value.ToString();                
                txtNombre.Text = DGVDepartamentos.Rows[Index].Cells[1].Value.ToString();
                CBEstatus.Text = DGVDepartamentos.Rows[Index].Cells[2].Value.ToString();
                txtClave.Enabled = false;
                btnAgregar.Enabled = false;
            } 
        }
        private Departamento GetInfo()
        {
            ModeloDepartamento.Clave = txtClave.Text;
            ModeloDepartamento.Nombre = txtNombre.Text;
            ModeloDepartamento.Estatus = CBEstatus.Text;
            return ModeloDepartamento;
        }

        private void CleanText()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            CBEstatus.Text = "";
            txtClave.Enabled = true;
            btnAgregar.Enabled = true;
        }
        private void ShowDepartamentos()
        {
            DGVDepartamentos.DataSource = CDepartamento.ShowDepartamentos().Tables[0];
            DGVDepartamentos.Columns[0].HeaderText = "Clave";
            DGVDepartamentos.Columns[1].HeaderText = "Nombre";
            DGVDepartamentos.Columns[2].HeaderText = "Estatus";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CleanText();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }
    }
}
