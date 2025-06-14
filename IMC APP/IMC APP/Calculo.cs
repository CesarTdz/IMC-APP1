using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IMC_APP
{
    class Calculo
    {
        public double CalcularIMC(double peso, double altura)
        {
            return Math.Round(peso / (altura * altura), 2);
        }

        public string ClasificarIMC(double imc)
        {
            if (imc < 18.5f)
            {
                return "Bajo peso";
            }
            else if (imc >= 18.5f && imc < 25f)
            {
                return "Peso normal";
            }
            else if (imc >= 25f && imc < 30f)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidad";
            }
        }
            
             public double CalcularKm(double sancada, double pasos)
        {
            return Math.Round((pasos * sancada) / 1000, 2);
        }

        public string VerificarPasos(double pasos, double imc)
        {
            if (imc < 18.5f)
            {
                return "Tienes bajo peso. Se recomienda no caminar demasiado para evitar desgaste excesivo.";
            }
            else if (pasos >= 10000)
            {
                return "¡Enhorabuena! Estás cumpliendo la cantidad de pasos correctamente.";
            }
            else if (pasos >= 5000)
            {
                return "Vas bien, pero intenta llegar hasta los 10,000 pasos.";
            }
            else
            {
                return "Necesitas caminar más, intenta alcanzar al menos 5,000 pasos.";
            }
        }
    }

}
    

   

