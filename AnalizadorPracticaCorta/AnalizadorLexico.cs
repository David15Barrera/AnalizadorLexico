using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AnalizadorPracticaCorta.MainWindow;

namespace AnalizadorPracticaCorta
{
    class AnalizadorLexico
    {
        public AnalizadorLexico()
        {

        }
        string palabra = "";

        public String DatoInicial(String cadena)
        {
            String retorno = " ";
            int numero = cadena.Length;
            MessageBox.Show("Cantidad de letras " + numero);
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i].Equals(' '))
                {
                    Reconocer(palabra);
                    palabra = "";
                }
                else
                {
                    palabra += cadena[i].ToString();
                }
            }
            retorno = Reconocer(palabra);
            palabra = "";
            return retorno;
        }

        // Almacena las palabras
        String palabraSuelta;
        public String Reconocer(String palabra)
        {
            palabraSuelta += Resolver(palabra) + "\n";
            return palabraSuelta;
        }
        /// <summary>
        /// Segun lo identificado en Dato inicial y mostrado en el reconocer
        /// nos vamos ha ver que tipo de dato es el que se almaceno
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public String Resolver(String palabra)
        {
            String letras = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            String numeros = "1234567890";
            String respuesta = "Identificado " + palabra + " No especificado ";

            int contador_letra = 0;
            int contador_numero = 0;
            int contador_punto = 0;

            // Identificado si es una palabra 
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < letras.Length; j++)
                {
                    if (palabra[i].Equals(letras[j]))
                    {
                        contador_letra++;
                        Console.WriteLine(contador_letra);
                    }
                }
            }
            // Identificando si es un numero
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (palabra[i].Equals(numeros[j]))
                    {
                        contador_numero++;
                    }
                }
            }
            // Error de punto
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i].Equals('.'))
                {
                    contador_punto++;
                }
             }
            // ALmacenamiento de que tipo de identificador es
            if (contador_letra == palabra.Length)
            {
                respuesta = "Identificador " +  palabra + "  es una Palabra ";        
                       }
            if (contador_numero == palabra.Length)
            {
                respuesta = "Identificador " + palabra + " es un Número Entero";
                
            }

            if (contador_punto == 1 && contador_numero == (palabra.Length - 1))
            {
                respuesta = "Identificador " +  palabra + " es un Número Decimal";
            }

            if (contador_numero == (palabra.Length - 2) && contador_punto == 1 && palabra[0].Equals('Q'))
            {
                respuesta = "Identificador " + palabra + " es una Moneda";
            }
            return respuesta;
        }
    }
}
