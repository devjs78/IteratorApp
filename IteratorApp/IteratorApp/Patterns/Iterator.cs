
namespace IteratorApp.Patterns
{
    using System;
    using System.Collections;

    public class Iterator : IIterator
    {
        //ref al listado completo
        private ArrayList Items;

        //almacenar el indice  en el que se encuentra el iterador
        private int posicionActual = 0;

        //ctor que inyectara el arreglo en el objeto
        public Iterator(ArrayList listado)
        {
            this.Items = listado;
        }

        public object Actual()
        {
            if ((this.Items == null) || (this.Items.Count == 0) || (posicionActual >= this.Items.Count))
            {
                return null;
                //return "VACIO";

            }
            else { return this.Items[posicionActual]; }

        }

        public void Primero()
        {
            this.posicionActual = 0;
        }

        public bool QuedanElementos()
        {
            return (posicionActual < this.Items.Count - 1);
        }

        public object Siguiente()
        {
            if ((this.Items == null) || (this.Items.Count == 0) || (posicionActual + 1 >= this.Items.Count))
            {
                return null;
            }
            else { return this.Items[++posicionActual]; }
        }
    }
}
