using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaArreglo.Interfaz
{
    class PromediosMatriz 
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            string[,] extraer_parcial = new string[matriz.GetLength(0), 6];
            extraer_parcial = matriz;
            string nombres = Convert.ToString(extraer_parcial[0, 1]);
            string seccio_grad = Convert.ToString(extraer_parcial[0, 5]);
            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    //extraer_parcial +=[nombres[0], seccio_grad[0]];
                }
            }

            return extraer_parcial; 
            
        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int promedio = 0;
            int acumulador = 0;
            switch (seccion)
            {
                case "A":
                    for (int fila=1; fila<matriz.GetLength(0); fila++)
                    {
                        acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
                    }
                    promedio = acumulador / (matriz.GetLength(0) - 1);
                    break;
                case "B":
                    for (int fila = 1; fila < matriz.GetLength(0); fila++)
                    {
                        acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
                    }
                    promedio = acumulador / (matriz.GetLength(0) - 1);
                    break;
                case "C":
                    for (int fila = 1; fila < matriz.GetLength(0); fila++)
                    {
                        acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
                    }
                    promedio = acumulador / (matriz.GetLength(0) - 1);
                    break;
                case "D":
                    for (int fila = 1; fila < matriz.GetLength(0); fila++)
                    {
                        acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
                    }
                    promedio = acumulador / (matriz.GetLength(0) -1);
                    break;
            }
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int promedio = 0;
            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedio = acumulador / (matriz.GetLength(0) - 1);
           
            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            return columna_parcial;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            return matriz;
        }
    }
}
