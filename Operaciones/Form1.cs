using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

               private void label3_Click(object sender, EventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(ingresar_Num1.Text);
            int numero2 = Convert.ToInt32(ingresar_Num2.Text);
            int sumar = numero1 + numero2;
            txt_resultado.Text = sumar.ToString();
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            ingresar_Num1.Text = " ";
            ingresar_Num2.Text = " ";
            txt_resultado.Text = " ";
        }
    }
}
