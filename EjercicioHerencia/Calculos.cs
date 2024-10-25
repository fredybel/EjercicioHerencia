using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public  class Calculos : Operaciones
    {
        public double Radio {  get; set; }
        public double  Millas { get; set; }

        public double Altura { get; set; }

        

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Longitud()
        {
            return Millas * 1.609344;
        }

        public override double Volumen()
        {
            return  (Math.Pow(Math.PI, 2) * Radio) * Altura;
        }
    }
    }


