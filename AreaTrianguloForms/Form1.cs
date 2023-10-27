using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
                //Ober valores:
                double n1 = double.Parse(txtAltura.Text);
                double n2 = double.Parse(txtBase.Text);
                //Mostrar resultados:
                txtResultado.Text = (n1 * n2 / 2).ToString();
            }
            catch
            {
                MessageBox.Show("Dados invadidos onformados!!");
                // Limpar txt:
                txtAltura.Clear();
                txtBase.Clear();
                txtResultado.Clear();
            }
            }
    }
}
