using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, tab, resultado;
            char car;
            
         do{
            
            Console.SetCursorPosition(30,2);
            Console.Write("********");
            Console.SetCursorPosition(32,3);
            Console.Write("* MENU *");
            Console.SetCursorPosition(30,4);
            Console.Write("********");
            Console.SetCursorPosition(15,5);
            Console.Write("Seleccione una opcion: \n\n 1.Adivinar un caracter \n 2.Tablas de Multiplicar \n 3.Suma de pares \n 4.Reloj Digital \n 5.Numeros Primos \n 6.Factorial de un numero\n 7.Numero decimal a binario\n 8.SALIR\n");
            Console.Write("\nOpcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Teclee una letra o número: ");
                    car = char.Parse(Console.ReadLine());

                    if(car!='a'&& car!='e' && car !='i' && car != 'o' && car != 'u')
                    {
                      if(car != '0'&& car != '1' && car != '2' && car != '3' && car != '4' && car != '5' && car != '6' && car != '7' && car != '8' && car != '9')
                        {
                            Console.Write("Es una consonante");
                        }
                        else
                        {
                            Console.Write("Es un numero");
                        }

                    }
                    else
                    {
                        Console.Write("Es una vocal");
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Escriba un numero para realizar su tabla de multiplicar: ");
                    tab = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= 10; i++)
                    {
                        resultado = tab * i;
                        Console.Write(tab + " x " + i + " = " + resultado + "\n");
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    int cont=0,par=0,rang;
                    float Sumimp=0,prom=0,primo,a;
                    Console.Write("Ingrese un numero limite: ");
                    rang = int.Parse(Console.ReadLine());
                    for (int j = 2; j <= rang; j+=2)
                    {
                       par+=j;
                    
                    }
                    for(int i=2;i<=rang;i++)
                   {
                          a=0;
                           for(int o=2;o<=i-1;o++)
                         {
                           {
                             primo=i%o;
                             if(primo==0){a=1;}
                           }
                           if(a==0){Sumimp=Sumimp+i;cont++;}
                         }  
                    }
          
                    prom=Sumimp/cont;
                    Console.WriteLine("\nSuma de numeros pares: " + par +"\n");
                    Console.WriteLine("\nPromedio de numeros impares: " + prom +"\n");
                    Console.ReadLine();
                    break;
                case 4:
                        
                     int op1;
                        Console.WriteLine("Simulacion de Reloj Digital: ");
                        Console.Write("Presione un tecla para continuar y despues enter 0 para salir:  ");
                        do{
                        
                        string tiempo;
                        tiempo = DateTime.Now.ToLongTimeString();
                        Console.WriteLine(tiempo);
                        op1=int.Parse(Console.ReadLine());
                         Console.Clear();
                        }while(op1!=0);
                    break;
                case 5:
                    int x,n,b,prim,num;
                    Console.Write("Ingrese un numero: ");
                    num = int.Parse(Console.ReadLine());
                    for(x=2;x<=num;x++){b=0;for(n=2;n<=x-1;n++){prim=x%n;if(prim==0){b=1;}}if(b==0){Console.WriteLine(" "+ x);}}
                    Console.ReadLine();
                    break;
                case 6:
                    int fac=1;
                    int numero;
                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero < 0){ fac =0; }
                    else
                    {
                       if (numero == 0){fac = 1;
                       }
                       else
                       {
                        for (int i = 1; i <= numero; i++)
                        {
                            fac = fac* i;
                        }
                        }
                    }
                    Console.Write("El factorial es: " + fac);
                    Console.ReadLine();
                     break;
                case 7:
                    int dec=0;
                    String cadena = "";
                    Console.Write("Ingrese un numero: ");
                    dec= int.Parse(Console.ReadLine());
                    while (dec > 0)
                    {
                      if (dec % 2 == 0)
                      {
                        cadena = "0" + cadena;
                      }
                      else
                      {
                        cadena = "1" + cadena;
                      }
                    dec = (int)(dec / 2);
                    }
                    Console.WriteLine(cadena);
                    Console.ReadLine();
                    break;
                 case 8:
                    Console.WriteLine("Saliendo del programa");
                    Console.ReadLine();
                     break;

                default:
                    Console.WriteLine("Elija una opcion existente");
                    Console.ReadLine();
                    break;
            }
                Console.Clear();

        }while(op!=8); 
            
        }
          
    }
}

