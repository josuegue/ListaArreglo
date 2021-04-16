using ListaArreglo.Arrelgos;
using ListaArreglo.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaArreglo
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 3;
            arreglo[3] = 32;
            arreglo[4] = 83;

            ClsArreglos ObjArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();
            for (int i = 0; i < resultado.Length; i++)
            {
                listBoxResultado.Items.Add($"valor={resultado[i]}");
            }
            //foreach (int i in arreglo)
            //{
            //    listBoxResultado.Items.Add(i);
            //}


        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Flor\Documents";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivos(archivo);
                textBoxContenido.Text = resultado;
            }

        }

        public int promedioSumaMatriz(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio = 0;
            int totalFila = matriz.GetLength(0);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila,columna]);
            }
            promedio = acumulador / (matriz.GetLength(0) - 1);
            return promedio;
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            //llamada a mi clase 
            PromediosMatriz objMatriz = new PromediosMatriz();
            ClsArchivo objArchivo = new ClsArchivo();
            //variables globales 
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];

            int contador = 0;
            int acumulador = 0, acumulador1 = 0, acumulador2 = 0;
            int promedio, promedio1, promedio2;
            //int sumaparciales;
            string[] CadenaNombres = new string[ArregloNotas.Length - 1];
            int[] OrdenParcila = new int[ArregloNotas.Length - 1];
            // extraccion de columnas del array, o extraer array de un array 
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {


                    acumulador += Convert.ToInt32(datos[2]);
                    acumulador1 += Convert.ToInt32(datos[3]);
                    acumulador2 += Convert.ToInt32(datos[4]);


                    OrdenParcila[contador - 1] = Convert.ToInt32(datos[2]);
                    CadenaNombres[contador - 1] = datos[1];
                }
                //Arreglo de dos dimensiones
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                ArregloDosDimensiones[contador, 5] = datos[5];

                contador++;
            }
            //promedio una seccion en general / ej "A"
            
            int promedio_seccion = objMatriz.promedios_general_seccion(ArregloDosDimensiones, 4, "D");
            MessageBox.Show($"El promedio de la seccion D es {promedio_seccion} ");
            //string seccion = "A";
            //string[] Nombre_secccion = objMatriz.Clasificar_Alumnos(ArregloDosDimensiones, seccion );







            int promedioMatriz = promedioSumaMatriz(ArregloDosDimensiones, 3);
            //promedios 
            ClsArreglos OrdArreglo = new ClsArreglos(OrdenParcila);
            //OrdenParcila = OrdArreglo.MetodoBurbuja();
            //int min = OrdenParcila[0];
            //int max = OrdenParcila[OrdenParcila.Length - 1];
            //promedio = acumulador / contador - 1;
            //promedio1 = acumulador1 / contador - 1;
            promedio2 = acumulador2 / contador - 1;
            //sumaparciales = promedio + promedio1 + promedio2 / 3;
            //MessageBox.Show($"Promedio del primer parciál {promedio}\nPromedio matriz {promedioMatriz}");
            //MessageBox.Show($"Promedio del segundo parcial {promedio1}");
            MessageBox.Show($"Promedio del  tercer parcial {promedio2}");
            //MessageBox.Show($"Promedio general de todos los parciales {sumaparciales}");
            //MessageBox.Show($"El maximo es {max} \nEl minimo es {min}");
            //recorrido de los nombres ordenados 
            CadenaNombres = objArchivo.MetodoBurbujaNombre(CadenaNombres);
            foreach (string recorrido in CadenaNombres)
            {
                listBoxResultado.Items.Add(recorrido);
            }
        }
        private void buttonOrdenamientoB_Click(object sender, EventArgs e)
        {
            ClsArchivo ObjArchivo = new ClsArchivo();
            foreach (string n in ArregloNotas)
            {
                string[] Datos = n.Split(';');
                listBoxResultado.Items.Add(Datos[1]);
            }
        }
       
    }
    

}

