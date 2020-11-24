using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones_algebraicas
{
    class ExpresionAlgebraica
    {
        public void evaluar_expresion(String expresion)
        {
            Pila pila = new Pila();
            int contadorAbre = 0;
            int contadorCierra = 0;

            for(int i=0; i<=expresion.Length-1; i++)
            {
                if(expresion.Substring(i,1) == "(")
                {
                    pila.insertar(Convert.ToChar(expresion.Substring(i, 1)));
                    contadorAbre++;
                }
                else
                {
                    if(expresion.Substring(i, 1) == ")")
                    {
                        pila.eliminar();
                        contadorCierra++;
                    }
                }
            }
            if (pila.vacia() && contadorAbre == contadorCierra)
                MessageBox.Show("Expresion ingresada correcta");
            else
                MessageBox.Show("Expresion ingresada incorrecta");
        }
    }
}
