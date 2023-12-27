using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo1222
{
    class Nodo
    {
        //el nodo va a tener un dato
        private string Dato;
        //apuntador de nodo siguiente
        private Nodo Siguinte;

        public string dato
        {
            //regresamos el tipo de dato
            get { return Dato; }
            //dato por algo que nos ingrese
            set { Dato = value; }
        }
        public Nodo siguiente
        {
            get
            {
                //returnar el dato siguiente
                return Siguinte;
            }
            set { Siguinte = value; }
        }



    }
}
