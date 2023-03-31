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

namespace CRUD.View
{
    public partial class ViewInformacion : Form
    {
        private string Query;
        private ControlTrabajador CntrlTrabajador;
        public ViewInformacion()
        {
            InitializeComponent();
            CntrlTrabajador = new ControlTrabajador();
            ShowInfo("Sp_TrabajadorEdad");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();
            Home.Show();
        }

        private void btnFechaIngreso_Click(object sender, EventArgs e)
        {
            ShowInfo("Sp_TrabajadorEdad");
        }

        private void btnFechaContratacionT_Click(object sender, EventArgs e)
        {
            ShowInfo("Sp_TrabajadorFechaInicio");
        }
        private void ShowInfo(string QueryObj)
        {
            DGVInformacion.DataSource = CntrlTrabajador.ShowTrabajadores(QueryObj).Tables[0];
        }
    }
}
