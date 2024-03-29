﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tareas.Tarea2
{
    public class PromedioArrayList
    {
        //este es el ejercicio 1 del capitulo 7
        public void CalcularPromedioArrayList()
        {
            int salida = 0, cont = 0;
            float calificacion = 0.0f, maxima = 0.0f, minima = 100.0f, promedio = 0.0f;
            ArrayList calificaciones = new ArrayList();

            Console.Clear();

            try
            {
                //aqui se toman las calificaciones
                while (salida != -1)
                {
                    Console.Write("\nIngresé la calificación {0}:", cont + 1, ":");
                    calificacion = Convert.ToSingle(Console.ReadLine());

                    calificaciones.Add(calificacion);

                    if (calificacion > maxima)
                        maxima = calificacion;
                    if (calificacion < minima)
                        minima = calificacion;
                    Console.WriteLine("Para terminar el programa ingresé -1 \n\n");
                    salida = Convert.ToInt32(Console.ReadLine());
                    cont++;

                }
                //aqui sumamos las calificaciones almacenadas en el arraylist
                foreach (float dato in calificaciones)
                {
                    promedio += dato;
                }

                Console.WriteLine("El promedio de calificaciones es:" + (Math.Round(promedio / calificaciones.Count, 2)));
                Console.WriteLine("La calificación mas alta es:" + maxima);
                Console.WriteLine("La calificación mas baja es:" + minima);
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error);
                Console.ReadKey();
            }
        }
    }
}
