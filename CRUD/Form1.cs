using CRUD.View;
namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            ViewTrabajador VTrabajador = new ViewTrabajador();
            VTrabajador.Show();
            this.Hide();

        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            ViewDepartamento VDepartamento = new ViewDepartamento();
            VDepartamento.Show();
            this.Hide();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            ViewInformacion VInformacion = new ViewInformacion();
            this.Hide();
            VInformacion.Show();
        }
    }
}