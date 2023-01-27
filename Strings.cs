/* Desarrollar un programa que pida por separado los nombres y apellidos, para posteriormente mostrar los siguientes resultados (una variable 
para los nombres y otra para los apellidos) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.Write(Introduce tu nombre );
            string nombres = Console.ReadLine();


            Console.Write(Intruduce tu apellido );
            string apellidos = Console.ReadLine();

            //Contadores
            int contadorName = 0;
            int contadorLastName = 0;

            //Concatenacion (cadenas)
            int contLN;

            //Remplace _
            string sumNP;
            sumNP = nombres + '_' + apellidos;

            Inicializadores
            int j;
            int i;

            Console.Clear();

            //Contador de caracteres
             //Bucle para determinar que el caracter en esa posición [j] en el string no sea un  
            for (i = 0; i  nombres.Length; i++)
            {
                 //Comprobamos que el caracter en esa posición [i] en el string no sea un  
                if (!char.IsWhiteSpace(nombres[i]))
                {
                    sumNP = sumNP.Replace( , _);
                    contadorName++;
                }
            }

            //Contador de caracteres
             //Bucle para determinar que el caracter en esa posición [j] en el string no sea un  
            for (j = 0; j  apellidos.Length; j++)
            {
                if (!char.IsWhiteSpace(apellidos[j]))
                {
                    sumNP = sumNP.Replace( , _);
                    contadorLastName++;
                }
            }

            Console.WriteLine(n1. La longitud por separado de los nombres, los apellidos y el nombre completo.n);
            Console.Write(${nombres});
            Console.WriteLine(  Cantidad de caracteres =  + contadorName);
            Console.Write(${apellidos});
            Console.WriteLine(  Cantidad de caracteres =  + contadorLastName);

            //Concatenación de los 2 contadores, nombres y apellidos para saber el total de caracteres
            contLN = contadorName + contadorLastName;

            Console.Write(${nombres} {apellidos});
            Console.WriteLine(  Cantidad de caracteres =  + contLN);

            Console.WriteLine(n2. Mostrar el nombre comleto.n);
            Console.WriteLine(${nombres} {apellidos});

            Console.WriteLine(n3. Mostrar el nombre completo remplazando los espacios por underscore (_).n);
            Console.WriteLine(${sumNP});

            Console.WriteLine(n4. Los nombres en mayúscula.n);
            Console.WriteLine(nombres.ToUpper());

            Console.WriteLine(n5. Los apellidos en minúscula.n);
            Console.WriteLine(apellidos.ToLower());

            Console.WriteLine(n6. El primer carácter del apellido.n);

            string subcadenaLastName = apellidos.Substring(0,1);
            Console.WriteLine(subcadenaLastName);

            Console.WriteLine(n7. El último carácter del nombre.n);

            //Inversion de cadena

            string cad, aux;
            cad = nombres;
            int cont;
            aux = ;
            cont = cad.Length - 1;

            while (cont = 0)
            {
                aux = aux + cad[cont];
                cont = cont - 1;
            }

            string subcadenaName = aux.Substring(0,1);
            Console.WriteLine(subcadenaName);
        }
    }
}
