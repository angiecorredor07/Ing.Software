using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Prototype
    {
        public string Class { get; set; }
        public double valor { get; set; }
        public Prototype Clone() {
            return MemberwiseClone() as Prototype;
        }
    }
}
