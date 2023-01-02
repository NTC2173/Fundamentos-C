using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    //POR DEFECTO, ESTA CLASE SOLO ES VISIBLE PARA ESTE PROYECTO DEBIDO A 'internal', CAMBIAMOS SU
    //VISIBILIDAD A 'public'

    //DECLARAMOS UNA ENUMERACION CON UNA SERIE DE VALORES. LA ENUMERACION SIEMPRE VA FUERA DE LA CLASE PERSONA
    public enum Paises { España, Francia, Alemania, Argentina }

    public class Persona
    {
        //LA PROPIEDAD SE DECLARA CON EL TIPO ENUMERADO
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //EN LAS PROPIEDADES EXTENDIDAS, QUE SON AQUELLAS EN LAS QUE DESEAMOS CONTROLAR ALGO SE UTILIZAN
        //CAMPOS PRIVADOS
        private int _Edad;

        public int Edad
        {
            get
            {
                //SE DEVUELVE EL CAMPO PRIVADO
                return _Edad;
            }
            set
            {
                //CAMBIAMOS EL CAMPO PRIVADO
                //COMPROBAMOS EL VALOR QUE TIENE
                if(value < 0)
                {
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
                
            }
        }
        //EN ALGUN MOMENTO, EN OTRO CODIGO, EL PROGRAMADOR IGUALARA EL DATO DE LA EDAD A ALGO
        //persona.Edad = 28;

        //DEBEMOS CREARNOS UN CONJUNTO PARA MANEJAR LA PROPIEDAD INDIZADA, DICHO CONJUNTO PODRIA SER
        //UN ARRAY O UNA COLECCION. PROPIEDAD _Descripciones. 4 descripciones
        private string[] _Descripciones = new string[3];
        //CREAMOS LA PROPIEDAD
        public string this[int indice]
        {
            //DEVOLVEMOS CON GET
            get
            {
                return this._Descripciones[indice];
            }
            //GUARDA DESCRIPCIONES
            set
            {
                this._Descripciones[(int)indice] = value;
            }
        }

        public virtual string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public override string ToString()
        {
           return this.Nombre + " " + this.Apellido + ", Edad: " + this.Edad;
        }

        //POLIMORFISMO

        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellido + " " + this.Nombre;
            }
            else
            {
                return this.Nombre + " " + this.Apellido;
            }
        }

        //PODEMOS CREAR TODOS LOS METODOS QUE QUERAMOS. NO TIENE QUE SER STRING TAMPOCO. 
        public void GetNombreCompleto(int num1, int num2) { }
        public void GetNombreCompleto(int num1, int num2, int num3) { }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellido = apellidos;
        }

        public Persona()
        {
        }
    }
}
