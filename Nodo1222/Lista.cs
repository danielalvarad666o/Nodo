using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo1222
{
    class Lista
    {
        //Lista crcular simple  ---ingresar los datos example 12,67,43,27
        //referencia del primero 
        private Nodo primero = new Nodo();
        //Referencia del ultimo
        private Nodo ultimo = new Nodo();
        //si la lista esta vacia 
        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarNODO()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingresa el palabra");
            nuevo.dato = Console.ReadLine();
            if (primero==null)
            {
                primero = nuevo;
                primero.siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
                ultimo = nuevo;
            }
            Console.WriteLine("la palabra se ingreso correctamente");
            Console.WriteLine("");
        }


        public void Mostrarlista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                //recorrer la lista 
               while(actual!=null)
                {
                    Console.WriteLine(actual.dato);
                    actual = actual.siguiente;
                    
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }

        public void Buscar()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            bool ENCONTRADO = false;
            if (primero != null)
            {
                Console.Write("Palabra  a buscar: ");
                string palabra = Console.ReadLine();


                do
                {

                    if (Actual.dato == palabra)
                    {
                        Console.WriteLine("palabra encontrada en la lista: " + Actual.dato);
                        ENCONTRADO = true;
                        Console.WriteLine("");
                    }

                    Actual = Actual.siguiente;
                } while (Actual != primero && Actual != null && ENCONTRADO != true);


                if (ENCONTRADO == false)
                {
                    Console.WriteLine("palabra no encontrada");
                    Console.WriteLine("");

                }


            } else
            {
                Console.WriteLine("Lista vacia");
                Console.WriteLine("");
            }


        }

        public void modificar()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            bool ENCONTRADO = false;
            if (primero != null)
            {
                Console.Write("Palabra  a Modificar: ");
                string palabra = Console.ReadLine();


                do
                {

                    if (Actual.dato == palabra)
                    {
                        Console.WriteLine("palabra encontrada en la lista: " + Actual.dato);
                        ENCONTRADO = true;
                        Console.WriteLine("Ingresa el nuevo dato: ");
                        Actual.dato = Console.ReadLine();
                        Console.WriteLine("Se a insertado correctamente");

                    }

                    Actual = Actual.siguiente;
                } while (Actual != primero && Actual != null && ENCONTRADO != true);


                if (ENCONTRADO == false)
                {
                    Console.WriteLine("palabra no encontrada");
                    Console.WriteLine("");

                }


            }
            else
            {
                Console.WriteLine("Lista vacia");
                Console.WriteLine("");
            }
        }

        public void Eliminarlista()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            Nodo Antes = new Nodo();
            Antes = null;
            
            bool ENCONTRADO = false;
            if (primero != null)
            {
                Console.Write("Palabra  a Eliminar: ");
                string palabra = Console.ReadLine();
                while (Actual!=null && ENCONTRADO!=true )
                {
                    if (Actual.dato == palabra)
                    {
                        Console.WriteLine("palabra encontrada en la lista: " + Actual.dato);
                        Console.WriteLine("");
                        if (Actual==primero)
                        {
                            primero = primero.siguiente;
                            
                        }
                        else if (Actual==ultimo)
                        {
                            Antes.siguiente = null;
                            ultimo = Antes;

                        }else
                        {
                            Antes.siguiente = Actual.siguiente;
                        }



                        ENCONTRADO = true;
                        Console.WriteLine("");
                        Console.WriteLine("el nodo fue eliminado correctamente");
                    }
                    Antes = Actual;
                    Actual = Actual.siguiente;
                }



                if (!ENCONTRADO)
                {
                    Console.WriteLine("palabra no encontrada");
                    Console.WriteLine("");

                }


            }
            else
            {
                Console.WriteLine("Lista vacia");
                Console.WriteLine("");
            }


        }

    }


}
