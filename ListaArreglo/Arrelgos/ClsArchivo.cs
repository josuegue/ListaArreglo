using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaArreglo.Arrelgos
{
    class ClsArchivo
    {
        //Me lee el archivo 
        public string[] LeerArchivos (string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo);
            return Lineas;
        }
        // me lee todo el contenido del archivo plano 
        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }
        //Metodo de burbuja
        public string[] MetodoBurbujaNombre(string[] OrdBurbuja)
        {

            string[] TamArreglo = OrdBurbuja;
            string[] ArregloOrd = TamArreglo;
            string datosTemporal;

            for (int i = 0; i < TamArreglo.Length - 1; i++)
            {
                for (int j = i + 1; j < TamArreglo.Length; j++)
                {
                    // COMO NO ES UN NUMERO SE UTILIZA EL COMPARE.TO 
                    // PARA COMPARAR LOS 2 STRING POR ORDEN ALFABETICO
                    if (ArregloOrd[i].CompareTo(ArregloOrd[j]) > 0)
                    {
                        datosTemporal = ArregloOrd[i];
                        ArregloOrd[i] = ArregloOrd[j];
                        ArregloOrd[j] = datosTemporal;
                    }
                }
            }
            return ArregloOrd;
        }
        public byte [] utfcodigo(string  text)
        {
            //string Texto = Convert.ToString(text);
            return Encoding.GetEncoding(1252).GetBytes(text);
        }
       /* 
        * implementar una nueva interfaz y ponerle Clspromedios , y que implemente interfaz promedio
        * osea lo que mando en telegram 
        * y ahi estan las directrices del parcila. 
        * agregar una 5ta columna con secciones en el archivo excel 
        */
    }
}
