using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodo1222
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            Lista lista = new Lista();
            Menu menu = new Menu();

            do
            {
                Console.WriteLine("");
                menu.MENUS();
                option = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                switch(option)
                {
                    case 'a':
                        lista.InsertarNODO();
                        break;
                    case 'c':
                        char option2;
                        Console.WriteLine("Quieres verlo de forma a) acendente  o  b) descendente");
                        Console.WriteLine("Escoje tu respuesta");
                      option2=Convert.ToChar(  Console.ReadLine());
                        if (option2 == 'a')
                        {
                            lista.Mostrarlista();
                        }else
                        {
                           // lista.MostrarlistaFI();
                        }
                        break;
                    case 'f':
                        lista.Buscar();
                        break;
                    case 'e':
                        lista.modificar();
                        break;
                    case 'd':
                        lista.Eliminarlista();
                        break;
                }
            } while (option!='h');
        }
    }
}
