using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Programa
    {
        static void Main(string[] args) {
            Prototype prototype = new Prototype();
            prototype.Class = "pregunta";
            prototype.valor = 0.2;

            Prototype Pregunta = prototype.Clone() as Prototype;
            Pregunta.Class = "Verdadero y Falso";
            Pregunta.valor = 0.2;

            Prototype Pregunta1 = prototype.Clone() as Prototype;
            Pregunta1.Class = "Unir Columnas";
            Pregunta1.valor = 0.3; 
        }
    }
}
