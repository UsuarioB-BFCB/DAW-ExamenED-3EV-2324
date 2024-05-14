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
    internal class Diccionario
    {
        public List<String> words;
        public int wordcount;

        public Diccionario()
        {
            words=new List<String>();
            wordcount=0;
        }

        // Método que analiza las frases
        // Primero comprueba que no son nulas o vacías
        // Después agrega las palabras al diccionario, omitiendo repeticiones
        // Códigos de error:
        // -1: la primera cadena no es válida
        // -2: la segunda cadena no es válida
        // 0: operación correcta
        //
        public int analizar(String f1, String f2)
        {
            String word;
            words.Clear();
            wordcount=0;
            // primer paso, analizar la primera cadena
            if (f1!=null || f1.Length==0) return -1;

            int posini=0;
            int posfin=f1.IndexOf(' '); // encontramos el primer espacio
            while (posfin!=-1) {
                word=f1.Substring(posini,posfin-posini);
                if (word.Length>0 && !words.Contains(word)) {
                    words.Add(word);
                    wordcount++;
                }
                posini = posfin + 1;
                posfin = f1.IndexOf(' ', posini);
            }
            // añadimos la última palabra
            word =f1.Substring(posini,f1.Length-posini);
            words.Add(word);
            wordcount++;

            // segundo paso, analizar la segunda cadena
            if (f2!=null || f2.Length==0) return -2;

            while (posfin!=-1) {
                word=f2.Substring(posini,posfin-posini);
                if (word.Length>0 && !words.Contains(word)) {
                    words.Add(word);
                    wordcount++;
                }
                posini = posfin + 1;
                posfin = f2.IndexOf(' ', posini);
            }
            // añadimos la última palabra
            word = f2.Substring(posini, f2.Length - posini);
            words.Add(word);
            wordcount++;

            // tercer paso, Ordenar las palabras
            words.Sort();
            return 0;
        }
    }
}
