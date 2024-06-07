using Examen3EV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3EV
{
    // Clase que construye un diccionario de palabras a partir de dos frases
    // El dicionario estará ordenado alfabéticamente
    public class DiccionarioBFCB
    {
        private List<String> palabras;
        public int contadorPalabras;
        public string ERROR_FRASE1_VACIA = "La frase no puede estar vacia";
        public string ERROR_FRASE2_VACIA = "La frase no puede estar vacia";

        public List<string> Palabras { get => palabras; set => palabras = value; }

        //Blanca F Civieta Bermemjo 23/24
        public DiccionarioBFCB()
        {
            palabras=new List<String>();
            contadorPalabras=0;
        }

        // Método que analiza las frases
        // Primero comprueba que no son nulas o vacías
        // Después agrega las palabras al diccionario, omitiendo repeticiones
        // Códigos de error:
        // -1: la primera cadena no es válida
        // -2: la segunda cadena no es válida
        // 0: operación correcta
        //
        /// <summary>
        /// <para>Metodo para construir un diccionario de palabras</para>
        /// </summary>
        /// <param name="frase1">parametro de entrada del metodo</param>
        /// <param name="frase2">parametro de entrada del metodo</param>
        /// <returns>el metodo te devuelve un "0" si todo se ha ejecutado correctamente</returns>
        /// <exception cref="ArgumentOutOfRangeException">captura un error si las frases estan vacias o son null</exception>
        public int Analizar(String frase1, String frase2)
        {
            String palabra;

            palabras.Clear();
            contadorPalabras=0;
           
            // primer paso, Analizar la primera cadena
            
            if (frase1 == null || frase1.Length == 0)
            {
                throw new ArgumentOutOfRangeException(ERROR_FRASE1_VACIA);
            }
            
            int posicionInicial=0;
            int posicionFinal=frase1.IndexOf(' '); // encontramos el primer espacio

            while (posicionFinal!=-1) 
            {
                palabra = frase1.Substring (posicionInicial, posicionFinal-posicionInicial);
               
                if (palabra.Length>0 && !palabras.Contains(palabra)) {
                    palabras.Add(palabra);
                    contadorPalabras++;
                }
                posicionInicial = posicionFinal + 1;
                posicionFinal = frase1.IndexOf(' ', posicionInicial);
            }
            // añadim os la última palabra
            palabra = frase1.Substring(posicionInicial,frase1.Length-posicionInicial);
            palabras.Add(palabra);
            contadorPalabras++;

            // segundo paso, Analizar la segunda cadena
            if (frase2 == null || frase2.Length == 0)
            {
                throw new ArgumentOutOfRangeException(ERROR_FRASE2_VACIA);
            }

            while (posicionFinal!=-1) 
            {
                palabra=frase2.Substring(posicionInicial,posicionFinal-posicionInicial);

                if (palabra.Length>0 && !palabras.Contains(palabra)) {
                    palabras.Add(palabra);
                    contadorPalabras++;
                }
                posicionInicial = posicionFinal + 1;
                posicionFinal = frase2.IndexOf(' ', posicionInicial);
            }
            // añadimos la última palabra
            palabra = frase2.Substring(posicionInicial, frase2.Length - posicionInicial);
            palabras.Add(palabra);
            contadorPalabras++;

            // tercer paso, Ordenar las palabras
            palabras.Sort();
            return 0;
        }
    }
}
