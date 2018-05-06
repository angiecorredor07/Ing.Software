using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Pregunta
    {
        private int id;
        private double valor;
        private string tipo;
        private double puntaje;
        private bool punto;

        public Pregunta() { }

        public int getId() {
            return id;
        }
        public void setId(int id) {
            this.id = id;
        }
        public double getValor() {
            return valor;
        }
        public void setValor(double valor) {
            this.valor = valor;
        }
        public double getPuntaje() {
            return valor + valor; 
        }
        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
       
}
    
}
