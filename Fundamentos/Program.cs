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
            SumarNumeros();
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
    }

         
}