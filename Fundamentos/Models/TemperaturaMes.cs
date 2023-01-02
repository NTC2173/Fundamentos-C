using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    //CREAMOS LA CLASE Y CAMBIAMOS INTERNAL --> PUBLIC
    public class TemperaturaMes
    {
        //CREAMOS UNA SERIE DE PROPIEDADES
        public string NombreMes { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }

        //CREAMOS UN METODO QUE NOS DEVOLVERA LA MEDIA
        public int GetMediaMes()
        {
            return (this.Maxima + this.Minima) / 2;
        }

    }
}
