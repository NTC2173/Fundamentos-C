using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo = 1200;
        }
    }
}
