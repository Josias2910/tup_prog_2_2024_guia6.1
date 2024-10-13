using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6._1___Ej1___Patentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string>
            {
                "OXY333", "OYZ 013", "AAA 123", "BCD-456", "AB 123 CD", "YZ5432EF", "QW 3456 AB"
            };

            IProcesable p = null;
            if (rbString.Checked)
            {
                p = new StringProcesableImpl();
            }
            else if (rbRegex.Checked)
            {
                p = new RegexProcesableImpl();
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
            }

            tbVer.Clear();
            foreach (string patente in patentes)
            {
                string descripcion = p.Procesar(patente, out string patenteFormateada);

                tbVer.Text += $"{patenteFormateada} {descripcion} \r\n";
            }
        }
    }
}
