using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaArreglo.Arrelgos
{
    class ClsArreglos
    {
        private int[] arregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;
        
        public int GetTamArreglo()
        {
            return datos.Length;
        }
        public ClsArreglos (int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; 
        }
        /// <summary>
        /// intercambiar cada pareja 
        /// consecutiva no ordenada. metodo burbuja
        /// </summary>
        /// <returns></returns>
        public int[] MetodoBurbuja()
        {
            arregloTemporal = datos;
            for (i=0; i<tamanoArreglo; i++)
            {
                for (j=i+1; j<tamanoArreglo; j++)
                {
                    if (arregloTemporal[i] > arregloTemporal[j])
                    {
                        datoTemporal = arregloTemporal[i];
                        arregloTemporal[i] = arregloTemporal[j];
                        arregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return arregloTemporal;
        }
    }
}
