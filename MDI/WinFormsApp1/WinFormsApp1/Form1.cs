namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmVentanaTexto ventanaTexto = Application.OpenForms.OfType<frmVentanaTexto>().FirstOrDefault();
            if (ventanaTexto == null)
            {
                ventanaTexto = new frmVentanaTexto();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
            else
            {
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
        }
    }
}
