using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones_algebraicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluarExpresion_Click(object sender, EventArgs e)
        {
            ExpresionAlgebraica expresionAlgebraica = new ExpresionAlgebraica();
            expresionAlgebraica.evaluar_expresion(txtBoxExpresion.Text);
            txtBoxExpresion.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
