using Fundamentos.Helpers;
using Fundamentos.Models;

namespace Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Metodo MAIN");
            //METODO PRINCIPAL DE EJECUCION 
            //REALIZAMOS LA LLAMADA DE LOS METODOS QUE DESEEMOS
            //PositivoNegativo();
            //NumeroMayorMenor();
            //DiaNacimientoSemana();
            //ConjeturaCollatz();
            //NumerosPares();
            //SumarNumeros();
            //EjemploClases();
            //ValidarEmail();
            //ValidarEmailPaco();
            //SumarNumerosString();
            //ValidarISBN();
            //EjemploColecciones();
            //SumarNumerosColeccion();
            //AdministrarTemperaturas();
            AdministrarTemperaturasHelper();

        }

        //CREAMOS NUESTROS PROPIOS METODOS
        static void PositivoNegativo()
        {
            Console.WriteLine("Programa positivo, negativo o cero");
            //PEDIMOS UNA VARIABLE Y LA RECUPERAMOS COMO STRING
            Console.WriteLine("");
            Console.WriteLine("Introduce numero: ");
            string dato = Console.ReadLine();
            //CONVERTIMOS EL DATO STRGIN EN INT
            int numero = int.Parse(dato);

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Cero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }


        }

        static void NumeroMayorMenor()
        {
            //DECLARAMOS 3 VARIABLES
            int mayor = 0, menor = 0, intermedio = 0; 
            Console.WriteLine("Introduzca numero 1: ");
            string dato = Console.ReadLine() ;
            int numero1 = int.Parse(dato);
            Console.WriteLine("Introduzca numero 2: ");
            dato = Console.ReadLine(); 
            int numero2 = int.Parse(dato);
            Console.WriteLine("Introduzca el numero 3: ");
            dato = Console.ReadLine();
            int numero3 = int.Parse(dato);

            if (numero1 >= numero2 && numero1 >=numero3)
            {
                mayor = numero1; 

            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3; 
            }

            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;

            }
            else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }

            int suma = numero1 + numero2 + numero3;
            intermedio = suma - mayor - menor;

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Intermedio: " + intermedio);

        }

        static void DiaNacimientoSemana()
        {
            Console.WriteLine("****Fecha Nacimiento****");
            Console.WriteLine("Dia: ");
            string dato = Console.ReadLine();
            int dia = int.Parse(dato);
            Console.WriteLine("Mes: ");
            dato = Console.ReadLine();
            int mes = int.Parse(dato);
            Console.WriteLine("Anio: ");
            dato = Console.ReadLine();
            int anio = int.Parse(dato); 

            //DEFINIMOS LAS CONDICIONES
            if(mes == 1)
            {
                mes = 13;
                //PARA RESTAR 1 A UNA VARIABLE SE PUEDE UTILIZAR: anio -= 1
                anio -= 1;

            }
            else if (mes == 2)
            {
                mes = 14;
                anio = anio - 1;

            }
            
           
            //SE IMPLEMENTAN LAS OPERACIONES
            int op1 = ((mes + 1)) * 3 / 5;
            int op2 = anio / 4;
            int op3 = anio / 100;
            int op4 = anio / 400;
            int op5 = dia + (2 * mes) + anio + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            //LA OP7 NOS DARA EL NUMERO QUE DEFINA EL DIA DE LA SEMANA
            int op7 = op5 - (op6 * 7);

            //MOSTRAMOS EL DIA POR PANTALLA
            if(op7 == 0)
            {
                Console.WriteLine("SABADO");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 1)
            {
                Console.WriteLine("DOMINGO");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 2)
            {
                Console.WriteLine("LUNES");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 3)
            {
                Console.WriteLine("MARTES");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 4)
            {
                Console.WriteLine("MIERCOLES");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 5)
            {
                Console.WriteLine("JUEVES");
                Console.WriteLine("Numero: " + op7);
            }
            else if (op7 == 6)
            {
                Console.WriteLine("VIERNES");
                Console.WriteLine("Numero: " + op7);
            }
            else
            {
                Console.WriteLine("Resultado incorrecto " + op7);
            }

        }

        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduce un numero: ");
            string dato = Console.ReadLine();   
            int numero = int.Parse(dato);

            while (numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (numero * 3) + 1;
                }
            }

            Console.WriteLine (numero);
        }

        static void NumerosPares()
        {
            Console.WriteLine("Introduce numero inicio: ");
            string dato = Console.ReadLine();
            int inicio = int.Parse(dato);

            Console.WriteLine("Introduce numero final: ");
            dato = Console.ReadLine();
            int final = int.Parse(dato);

            if (inicio > final)
            {
                while (inicio > final)
                {
                    Console.WriteLine("El numero de inicio no puede ser mayor que el numero final");
                    Console.WriteLine("Introduzca de nuevo los valores");
                    Console.WriteLine("");

                    Console.WriteLine("Introduce numero inicio: ");
                    dato = Console.ReadLine();
                    inicio = int.Parse(dato);

                    Console.WriteLine("Introduce numero final: ");
                    dato = Console.ReadLine();
                    final = int.Parse(dato);


                }
            }

            Console.WriteLine("Numeros pares del rango: ");
            for (int i=inicio; i <= final; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }

        static void SumarNumeros()
        {
            int suma = 0;

            Console.WriteLine("a) Introduzca numero para ir sumando ");
            Console.WriteLine("b) Pulsa 0 para termminar el programa ");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);

            while (numero != 0)
            {
                suma = suma + numero;
                Console.WriteLine("Introduzca otro numero: ");
                dato = Console.ReadLine();
                numero = int.Parse(dato);

            }

            Console.WriteLine("Suma total: " + suma);


        }

        static void EjemploClases()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortDateString());
            //RECORREMOS TODOS LOS ELEMENTOS DEL CODIGO ASCII
            for(int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS CADA int A CARACTER char
                char letra = (char)i;
                if(char.IsNumber(letra))
                {
                    Console.WriteLine(letra); 
                }
            }
        }

        static void ValidarEmail()
        {
            Console.WriteLine("Introduce un email valido: ");
            string email = Console.ReadLine();

            if (email.Contains("@") == false)
            {
                //BUSCA EL '@' EN EL TEXTO Y SI NO LO ENCUENTRA DEVUELVE UN FALSE
                Console.WriteLine("No existe @");
            }
            else if (email.IndexOf(".") == -1)
            {
                //BUSCA EL '.' EN EL TEXTO Y DEVUELVE SU POSICION. SI NO LO ENCUENTRA DEVUELVE UN -1
                Console.WriteLine("No existe '.' ");
            }
            else if (email.StartsWith("@") || email.EndsWith("@") || email.StartsWith(".") || email.EndsWith("."))
            {
                //QUE NO COMIENCE EL EMAIL POR '@' O '.' NI TERMINE CON AMBOS CARACTERES
                Console.WriteLine("Existe @ o punto al principio o final del email");
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                //LastIndexOf BUSCA EN TODA LA TEXTO EN LA CADENA Y DEVUELVE SU POSICION, COMIENZA A BUSCAR DESDE EL FINAL DE LA CADENA
                //IndezOf MISMA OPERACION QUE LastIndexOf PERO COMIENZA A BUSCAR DESDE EL PRINCIPIO
                Console.WriteLine("Existe más de una @");
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                //igntc93@gmail.com
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    Console.WriteLine("Email Válido");
                }
                else
                {
                    Console.WriteLine("El dominio debe ser de 2 a 4 caracteres");
                }
            }



        }
        //•	Exista @
        //•	Exista un punto
        //•	Exista un punto después de una @
        //•	Que no comience por @ ni punto
        //•	Solamente una @
        //•	Dominio debe ser de 2-4 caracteres

        static void ValidarEmailPaco()
        {
            Console.WriteLine("Introduzca un mail válido");
            string email = Console.ReadLine();
            if (email.Contains("@") == false)
            {
                Console.WriteLine("No existe @");
            }
            else if (email.IndexOf(".") == -1)
            {
                Console.WriteLine("No existe .");
            }
            else if (email.StartsWith("@") || email.EndsWith("@")
                || email.StartsWith(".") || email.EndsWith("."))
            {
                Console.WriteLine("Punto o @ al inicio o al final del mail");
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                Console.WriteLine("Debe existir un punto después de la @");
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                Console.WriteLine("Existe más de una @");
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                //igntc93@gmail.com
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    Console.WriteLine("Email correcto!!!");
                }
                else
                {
                    Console.WriteLine("El dominio debe ser de 2 a 4 caracteres");
                }
            }
        }

        static void SumarNumerosString()
        {
            Console.WriteLine("Introduzca un texto solo con numeros: ");
            string texto = Console.ReadLine();
            int suma = 0;

            //RECORREMOS TODOS LOS CARACTERES DEL TEXTO
            for(int i=0; i < texto.Length; i++)
            {
                //RECUPERMOS CADA CARACTER POR SU POSICION
                char caracter = texto[i];
                //CONVERTIMOS CADA CARACTER '1' A UN NUMERO int, PARA HACERLO, DEBEMOS RECUPERAR EL LITERAL DEL NUMERO "1"
                int numero = int.Parse(caracter.ToString());
                suma += numero; 
            }

            Console.WriteLine("La suma de " + texto + " es " + suma);

        }

        static void ValidarISBN()
        {
            Console.WriteLine("Introduzca numero ISBN: ");
            string isbn = Console.ReadLine();
            

            if (isbn.Length != 10)
            {
                Console.WriteLine("Numero ISBN tiene que tener 10 caracteres");
                
            }
            else
            {
                int suma = 0; 

                for(int i=0; i < isbn.Length; i++)
                {
                    //EXTRAER EL VALOR CARACTER DE LA POSICION
                    char caracter = isbn[i];
                    //TRANSFORMAR EL CARACTER EN NUMERO
                    int numero = int.Parse(caracter.ToString());

                    int operacion = numero * (i + 1);

                    suma += operacion; 
                }

                if(suma % 11 == 0)
                {
                    Console.WriteLine("Numero ISBN correcto");
                }
                else
                {
                    Console.WriteLine("Numero ISBN incorrecto");
                }

                
            }
            
        }

        static void EjemploColecciones()
        {
            //CREAMOS UNA COLECCION DE int
            List<int> numeros = new List<int>();
            //MEDIANTE EL METODO add PODEMOS AÑADIR ELEMENTOS
            numeros.Add(99);
            numeros.Add(445);
            //AL SER TIPADA LA COLECCION, EL COMPILADOR DETECTA ERRORES SI NO AÑADIMOS NUMEROS
            Console.WriteLine("Elementos de la coleccion " + numeros.Count);
            //PODEMOS RECORRER TODOS LOS ELEMENTOS DE LA COLECCION
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            //CREAMOS UN ARRAY DE NOMBRES
            List<string> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Adrian");
            nombres.Add("Lucia");
            nombres.Add("Ana");
            //QUE SUCEDE SI ELIMINAMOS UN ELEMENTO COMO OBJETO?
            //ELIMINA POR LA PRIMERA COINCIDENCIA
            //nombres.Remove("Ana");
            nombres.RemoveAt(3);
            foreach (string name in nombres)
            {
                Console.WriteLine(name);
            }
        }

        static void SumarNumerosColeccion()
        {
            //CREAMOS LA LISTA
            List<int> numeros = new List<int>();

            Console.WriteLine("Introduzca numero: ");
            string dato = Console.ReadLine();
            int num = int.Parse(dato);
            
            while(num != 0)
            {
                //PARA AÑADIR NUMEROS A LA COLECCION
                numeros.Add(num);
                Console.WriteLine("Introduzca numero: ");
                dato = Console.ReadLine();
                num = int.Parse(dato);
                
            }

            //SUMAR NUMEROS DE LA COLECCION
            int suma = 0;

            //LA VARIABLE n VA A SERVIR COMO ÍNDICE RECORRIENDO LA LISTA PERO ES CAPAZ DE LEER EL CONTENIDO MEDIANTE foreach 
            foreach (int n in numeros)
            {
                suma += n;
                //MOSTRAR NUMEROS POR PANTALLA
                Console.WriteLine(n);
            }

            Console.WriteLine("Elementos almacenados: " + numeros.Count);

            //PARA HACER LA MEDIA
            float media = suma / numeros.Count;
            Console.WriteLine("Media de los numeros: " + media);

        }

        static void AdministrarTemperaturas()
        {
            //QUEREMOS GENERAR 12 TEMPERATURAS
            //ASIGNAMOS VALORES ALEATORIOS AL MAXIMO Y MINIMO
            //PARA GENERAR VALORES ALEATORIOS DENTRO DE NET SE 
            //UTILIZA LA CLASE RANDOM
            //DICHA CLASE TIENE UN METODO Next() QUE NOS 
            //DEVUELVE UN NUMERO ALEATORIO ENTRE UN MINIMO Y UN MAXIMO
            Random random = new Random();
            //ALMACENAREMOS LOS 12 MESES EN UNA COLECCION
            List<TemperaturaMes> meses = new List<TemperaturaMes>();
            //REALIZAMOS UN BUCLE DE 1 A 12 PARA IR CREANDO MES A MES
            //Y AÑADIENDOLO A LA COLECCION
            for (int i = 1; i <= 12; i++)
            {
                //DENTRO DEL BUCLE IREMOS CREANDO UN MES EN CADA VUELTA
                TemperaturaMes mes = new TemperaturaMes();
                mes.NombreMes = "Mes " + i;
                mes.Maxima = random.Next(20, 60);
                mes.Minima = random.Next(-5, 17);
                //AÑADIMOS CADA MES A LA COLECCION
                meses.Add(mes);
            }
            //EN ESTE PUNTO YA TENEMOS 12 MESES.  PODEMOS HACER CUALQUIER
            //CODIGO, MOSTRARLOS, VER SU MEDIA O LO QUE SE NOS OCURRA...
            //SIMPLEMENTE VAMOS A RECORRER LOS MESES GUARDADADOS Y MOSTRAMOS SUS DATOS
            foreach (TemperaturaMes mes in meses)
            {
                Console.WriteLine(mes.NombreMes + ", Máxima: "
                    + mes.Maxima + ", Mínima: " + mes.Minima
                    + ", Media mensual: " + mes.GetMediaMes());
            }
            Console.WriteLine("Fin de programa");
        }

        static void AdministrarTemperaturasHelper()
        {
            HelperMeses helper = new HelperMeses();
            foreach (TemperaturaMes mes in helper.Meses)
            {
                Console.WriteLine(mes.NombreMes + ", Maxima: "
                    + mes.Maxima + ", Minima " + mes.Minima + ", Media mensual: "
                    + mes.GetMediaMes());
            }

            //SE PUEDEN GENERARAR OTROS DATOS DE LOS MESES MEDIANTE LO SIGUIENTE
            //helper.GenerarNuevosDatosMeses();
            //foreach (TemperaturaMes mes in helper.Meses)
            //{
            //Console.WriteLine(mes.NombreMes + "Maxima: " + mes.Maxima + ", Minima: " + mes.Minima + " Media mensual: " + mes.GetMediaMes());
            //}

            Console.WriteLine("Media anual: " + helper.GetMediaAnual());
            Console.WriteLine("Maxima anual: " + helper.GetMaximaAnual());
            Console.WriteLine("Minima anual " + helper.GetMinimaAnual());
        }



    }

         
}