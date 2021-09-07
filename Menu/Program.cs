using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static int Buscar (int[] arr, int d, int cont)
        {
            int pos = -1;
            //BUSQUEDA CON EL CICLO FOR
            for (int i = 0; i<cont;i++)
            {
                if (arr[i] ==d)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        static void Main(string[] args)
        {
            //OPERACIONES CON ARREGLOS
            const int DIM = 10;
            int opc = 0;
            int[] arreglo = new int[DIM];
            int num, cont = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de operaciones");
                Console.WriteLine("1. Agregar un numero");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Ordenar");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Digite la opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        if (cont < DIM)
                        {
                            Console.WriteLine("Digite el numero que desea agregar " + (cont + 1) + "/" + DIM);
                            num = Convert.ToInt32(Console.ReadLine());
                            arreglo[cont] = num;
                            cont++;
                        }
                        else
                        {
                            Console.WriteLine("El arreglo ya esta lleno");
                        }
                        break;
                    case 2:
                        //BUSCAR
                        Console.WriteLine("Digite el numero que desea buscar : ");
                        num = Convert.ToInt32(Console.ReadLine());
                        bool encontrado = false;
                        int a = 0;
                        int pos = -1;
                        while (a < cont && !encontrado)
                        {
                            if (arreglo[a] == num)
                            {
                                encontrado = true;
                                pos = a;
                            }

                            else
                            {
                                a++;
                            }
                        }
                        if (encontrado)
                        {
                            Console.WriteLine("El numero " + num + " esta en la posicion " + (pos + 1));
                        }
                        else
                        {
                            Console.WriteLine("El numero " + num + " no esta en el arreglo");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite el numero que desea modificar: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        int posM = -1;
                        //BUSQUEDA DEL CICLO FOR
                        for (int i = 0; i < cont; i++)
                        {
                            if (arreglo[i]==num)
                            {
                                posM = i;
                                break;
                            }
                        }
                        if (posM>=0)
                        {
                            Console.WriteLine("Digite el nuevo valor: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            arreglo[posM] = num;
                        }
                        else
                        {
                            Console.WriteLine("El numero " + num + " no se encuentra en el arreglo, motivo por el cual no se puede modificar");
                        }
                        break;
                    case 4:
                        //ELIMINAR
                        Console.WriteLine("Digite el numero que desea eliminar: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        int posE = -1;
                        for (int i = 0; i < cont; i++)
                        {
                            if (arreglo[i] == num)
                            {
                                posE = i;
                                break;
                            }
                        }
                        if (posE >= 0)
                        {
                            for (int j = posE;j< cont-1; j++)
                            {
                                arreglo[j] = arreglo[j + 1];
                            }
                            arreglo[cont - 1] = 0;
                            cont--;
                        }
                        else
                        {
                            Console.WriteLine("El numero " + num + " no se encuentra en el arreglo");
                        }
                        break;
                    case 5:
                        if (cont == 0)
                        {
                            Console.WriteLine("El arreglo esta vacio");
                        }
                        else
                        {
                            for(int i = 0; i<cont;i++)
                            {
                                Console.WriteLine("Arreglo[" + (i + 1) + "]:" + arreglo[i]);
                            }
                        }
                        break;
                    case 6:
                        for (int i = 0; i <cont-1;i++)
                        {
                            for(int j = i; j < cont;j++)
                            {
                                if (arreglo[i] > arreglo[j])
                                {
                                    int aux = arreglo[i];
                                    arreglo[i] = arreglo[j];
                                    arreglo[j] = aux;
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Abandonando el programa");
                        break;
                    default:
                        Console.WriteLine("Error, la opcion no esta definida");
                        break;

                }
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadKey();
            } while (opc != 7);
        }
    }
}
