using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface InterfaseDAO
    {
        public List<Pregunta> getPregunta();
        public Pregunta getPreguntaTipo(string tipo);
        public Pregunta getPreguntaValor(double valor);
        public void calificacionPregunta(Pregunta pregunta);
        Pregunta GetById(int id);
        bool Update(Pregunta pregunta);
    }
}
