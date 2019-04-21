using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Persona
    {
        private int edad;
        private String nombre;
        private String apellido;
        private int diaNacimiento;
        private int mesNacimiento;
        private int anioNacimiento;

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int AnioNacimiento { get => AnioNacimiento1; set => AnioNacimiento1 = value; }
        public int DiaNacimiento { get => diaNacimiento; set => diaNacimiento = value; }
        public int MesNacimiento { get => mesNacimiento; set => mesNacimiento = value; }
        public int AnioNacimiento1 { get => anioNacimiento; set => anioNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
