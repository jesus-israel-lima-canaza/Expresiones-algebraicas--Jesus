using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones_algebraicas
{
    class Pila
    {
        static int maxpila = 50;
        public int tope;
        public char[] lista;

        public Pila()
        {
            tope = -1;
            lista = new char[maxpila];
        }

        public bool vacia()
        {
            if (tope == -1)
                return true;
            else
                return false;
        }
        private bool llena()
        {
            if (tope == maxpila - 1)
                return true;
            else
                return false;
        }

        public void insertar(char x)
        {
            if (llena())
                MessageBox.Show("La pila esta llena, no se puede insertar más elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tope++;
                lista[tope] = x;
            }
        }

        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("La pila esta vacía, no se puede eliminar elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Elemento eliminado es: " + lista[tope]);
                tope--;
            }
        }


    }


}
