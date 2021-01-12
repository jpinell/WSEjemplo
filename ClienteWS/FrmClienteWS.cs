using System;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class FrmClienteWS : Form
    {
        public FrmClienteWS()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;

            using (WSPersonas.WSPersonasClient cliente = new WSPersonas.WSPersonasClient())
            {
                WSPersonas.Persona persona = cliente.ObtenerPersona(identificacion);
                string nombre = persona.Nombre;
                int edad = persona.Edad;
                string mensaje = persona.Error;

                label2.Text = nombre; label3.Text = edad.ToString(); label4.Text = mensaje;

            }
        }
    }
}
