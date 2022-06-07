using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione el proyecto: ");
                Console.WriteLine("Para el ejercicio nivel 1, número 1 introduzca 1.1");
                Console.WriteLine("Para el ejercicio nivel 1, número 2 introduzca 1.2");
                Console.WriteLine("Para el ejercicio nivel 1, número 5 introduzca 1.5");
                Console.WriteLine("Para el ejercicio nivel 2, número 1 introduzca 2.1y2");
                Console.WriteLine("Para el ejercicio nivel 2, número 3 introduzca 2.3");
                Console.WriteLine("Para el ejercicio nivel 2, número 4 introduzca 2.4");
                Console.WriteLine("Para el ejercicio nivel 2, número 5 introduzca 2.5");
                Console.WriteLine("Para el ejercicio nivel 2, número 6 introduzca 2.6");
                Console.WriteLine("Para el ejercicio nivel 2, número 7 introduzca 2.7");
                Console.WriteLine("Para el ejercicio nivel 2, número 8 introduzca 2.8");
                Console.WriteLine("Para el ejercicio nivel 2, número 9 introduzca 2.9");
                Console.WriteLine("Para el ejercicio nivel 2, número 10 introduzca 2.10");
                Console.WriteLine("Para el ejercicio nivel 2, número 11 introduzca 2.11");
                Console.WriteLine("Para el ejercicio nivel 2, número 12 introduzca 2.12");
                Console.WriteLine("Para el ejercicio nivel 2, número 13 introduzca 2.13");
                Console.WriteLine("Para el ejercicio nivel 2, número 14 introduzca 2.14");
                Console.WriteLine("Para el ejercicio nivel 2, número 15 introduzca 2.15");
                Console.WriteLine("Para el ejercicio nivel 3, número 1 introduzca 3.1");
                Console.WriteLine("Para el ejercicio nivel 3, número 2 introduzca 3.2");
                Console.WriteLine("Para el ejercicio nivel 3, número 3 introduzca 3.3");
                string ejercicio = Console.ReadLine();
                switch (ejercicio)
                {
                    case "1.1":
                        {
                            PrimeroPrimero();
                            Console.ReadKey();
                            break;
                        }
                    case "1.2":
                        {
                            PrimeroSegundo();
                            Console.ReadKey();
                            break;
                        }
                    case "1.5":
                        {
                            PrimeroQuinto();
                            Console.ReadKey();
                            break;
                        }
                    case "2.1y2":
                        {
                            DosUnoyDos();
                            Console.ReadKey();
                            break;
                        }
                    case "2.3":
                        {
                            DosTres();
                            Console.ReadKey();
                            break;
                        }
                    case "2.4":
                        {
                            DosCuatro();
                            Console.ReadKey();
                            break;
                        }
                    case "2.5":
                        {
                            DosCinco();
                            Console.ReadKey();
                            break;
                        }
                    case "2.6":
                        {
                            DosSeis();
                            Console.ReadKey();
                            break;
                        }
                    case "2.7":
                        {
                            DosSiete();
                            Console.ReadKey();
                            break;
                        }
                    case "2.8":
                        {
                            DosOcho();
                            Console.ReadKey();
                            break;
                        }
                    case "2.9":
                        {
                            DosNueve();
                            Console.ReadKey();
                            break;
                        }
                    case "2.10":
                        {
                            DosDiez();
                            Console.ReadKey();
                            break;
                        }
                    case "2.11":
                        {
                            DosOnce();
                            Console.ReadKey();
                            break;
                        }
                    case "2.12":
                        {
                            DosDoce();
                            Console.ReadKey();
                            break;
                        }
                    case "2.13":
                        {
                            DosTrece();
                            Console.ReadKey();
                            break;
                        }
                    case "2.14":
                        {
                            DosCatorce();
                            Console.ReadKey();
                            break;
                        }
                    case "2.15":
                        {
                            DosQuince();
                            Console.ReadKey();
                            break;
                        }
                    case "3.1":
                        {
                            Tresuno();
                            Console.ReadKey();
                            break;
                        }
                    case "3.2":
                        {
                            TresDos();
                            Console.ReadKey();
                            break;
                        }
                    case "3.3":
                        {
                            TresTres();
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("El número introducido es incorrecto.");
                            break;
                        }
                }
            }
        }
        public static void PrimeroPrimero()
        {
            Console.WriteLine("hola");
            int a = 1;
            int b = 2;
            var suma = a + b;
            var resta = a - b;
            var multiplicacion = a * b;
            var division = a / b;
            var modulo = a % b;
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multiplicacion);
            Console.WriteLine(division);
            Console.WriteLine(modulo);
        }
        public static void PrimeroSegundo()
        {
            int N;
            double A;
            char C;
            N = 5;
            A = 4.56;
            C = 'a';
            Console.WriteLine(A);
            Console.WriteLine(N);
            Console.WriteLine(C);
            Console.WriteLine(N + A);
            Console.WriteLine(A - N);
            Console.WriteLine(Char.GetNumericValue(C));
        }
        public static void PrimeroQuinto()
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;
            B = C;
            C = A;
            A = D;
            D = B;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);
        }
        public static void DosUnoyDos()
        {
            int A = 1;
            int B = 2;
            int C = 3;
            var suma = A + B + C;
            Console.WriteLine(suma);
            string nombreUsuario;
            string nombreCiudad;
            Console.WriteLine("Dime tu nombre: ");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Dime el nombre de una ciudad: ");
            nombreCiudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombreUsuario + " bienvenido a " + nombreCiudad);
        }
        public static void DosTres()
        {
            string nombreUsuario;
            int edad;

            Console.WriteLine("Dime tu nombre: ");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Dime tu edad: ");
            string inputEdad = Console.ReadLine();
            Int32.TryParse(inputEdad, out edad);
            Console.WriteLine("Te llamas " + nombreUsuario + " y tienes " + edad + " años");
        }
        public static void DosCuatro()
        {
            int A = 0;
            int B = 0;
            Console.WriteLine("ingrese el primer número: ");
            string inputA = Console.ReadLine();
            Console.WriteLine("ingrese el segundo número: ");
            string inputB = Console.ReadLine();
            Int32.TryParse(inputA, out A);
            Int32.TryParse(inputB, out B);

            if (A > B)

                Console.WriteLine("El número mayor es " + A);
            else
                Console.WriteLine("El número mayor es " + B);

        }
        public static void DosCinco()
        {
            Console.WriteLine("¿Que día es hoy?");
            string dia = Console.ReadLine().ToLower();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default:
                    Console.WriteLine("El valor ingresado es incorrecto.");
                    break;
            }
        }
        public static void DosSeis()
        {
            Console.WriteLine("indique el valor del producto a pagar: ");
            string valorString = Console.ReadLine();
            int valor;
            Int32.TryParse(valorString, out valor);
            Console.WriteLine("indique el metodo de pago: ");
            Console.WriteLine("En caso de pagar con tarjeta ingrese 1");
            Console.WriteLine("En caso de pagar con efectivo ingrese 2");
            string metodoPago = Console.ReadLine();
            switch (metodoPago)
            {
                case "1":
                    Console.WriteLine("Porfavor, ingrese su numero de cuenta");
                    string cuenta = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("En un momento será atendido por uno de nuestros empleados");
                    break;
                default:
                    Console.WriteLine("El valor ingresado es incorrecto.");
                    break;
            }
        }
        public static void DosSiete()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void DosOcho()
        {
            int i = 0;
            while(i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void DosNueve()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i %2 == 0)
                Console.WriteLine(i);
            }

        }
        public static void DosDiez()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 | i % 3 == 0 )
                    Console.WriteLine(i);
            }

        }
        public static void DosOnce()
        {
            int A = 0;
            int B = 0;
            Console.WriteLine("ingrese el primer número: ");
            string inputA = Console.ReadLine();
            Console.WriteLine("ingrese el segundo número: ");
            string inputB = Console.ReadLine();
            Int32.TryParse(inputA, out A);
            Int32.TryParse(inputB, out B);

            if (A > B)

                Console.WriteLine("El número mayor es " + A);
            else if (A < B)
                Console.WriteLine("El número mayor es " + B);
            else
                Console.WriteLine("Los dos números ingresados son iguales");
        }
        public static void DosDoce()
        {
            double A = 0;
            double pi = Math.PI;
            Console.WriteLine("ingrese el radio del circulo del que quiera calcular el area: ");
            string inputA = Console.ReadLine();
            double.TryParse(inputA, out A);
            double area = Math.Pow(A, 2) * pi;
            Console.WriteLine("el area de este circulo será: " + area);
        }
        public static void DosTrece()
        {
            Console.WriteLine("Ingrese un número para saber si es divisible por 2");
            int A = 0;
            string inputA = Console.ReadLine();
            Int32.TryParse(inputA, out A);
            if (A % 2 == 0)
            
                Console.WriteLine("El numero es divisible por 2");
            else
                Console.WriteLine("El numero no es divisible por 2");
        }
        public static void DosCatorce()
        {
            Console.WriteLine("Ingrese el valor del producto para calcular el valor final con IVA añadido:");
            double A = 0;
            string inputA = Console.ReadLine();
            double.TryParse(inputA, out A); 
            double precioIVA = (A * 0.21) +A;
            Console.WriteLine("El valor final sera de " + precioIVA);
        }
        public static void DosQuince()
        {
            double total = 0;
            Console.WriteLine("Ingrese un número de ventas");
            int ventas = 0;
            string inputVentas = Console.ReadLine();
            Int32.TryParse(inputVentas, out ventas);
            Console.WriteLine("Ingrese el valor de las ventas de una en una:");
            for (int i= 0; i < ventas; i++)
            {
                Console.WriteLine("Ingrese el valor de la siguiente venta: ");
                double valor = 0;
                string inpuntValor = Console.ReadLine();
                double.TryParse(inpuntValor, out valor);
                total += valor;
            }
            Console.WriteLine("el valor total de todas las ventas es de " + total);
        }
        public static void Tresuno()
        {
            Console.WriteLine("¿Que día es hoy?");
            string dia = Console.ReadLine().ToLower();
            switch (dia)
            {
                case "lunes":
              
                case "martes":
                
                case "miercoles":
               
                case "jueves":
                    
                case "viernes":
                    Console.WriteLine("Es laborable");
                    break;
                case "sabado":
                  
                case "domingo":
                    Console.WriteLine("No es laborable");
                    break;
                default:
                    Console.WriteLine("El valor ingresado es incorrecto.");
                    break;
            }

        }
        public static void TresDos()
        {
            string password = "1234";
            for(int i = 0; i < 3; i++)
            {
            Console.WriteLine("introduzca la contraseña: ");
            string intento = Console.ReadLine();
             if (intento == password)
                {
                    Console.WriteLine("Enhorabuena!");
                    return;
                }
             else
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
            }
        }
        public static void TresTres()
        {
            int A = 0;
            int B = 0;
            
            
            Console.WriteLine("ingrese el primer número: ");
            string inputA = Console.ReadLine();
            Console.WriteLine("ingrese el segundo número: ");
            string inputB = Console.ReadLine();
            Int32.TryParse(inputA, out A);
            Int32.TryParse(inputB, out B);
            Console.WriteLine("ingrese el signo aritmético de la operación que quiera realizar: ");
            string signo = Console.ReadLine();
            switch (signo)
            {
                case "+":
                    Console.WriteLine(A + B);
                    break;
                case "-":
                    Console.WriteLine(A - B);
                    break;
                case "*":
                    Console.WriteLine(A * B);
                    break;
                case "/":
                    double resultadoDivision = A / B;
                    Console.WriteLine(resultadoDivision);
                    break;
                case "^":
                    double resultadoPotencia = Math.Pow(A, B);
                    Console.WriteLine(resultadoPotencia);
                    break;
                case "%":
                    Console.WriteLine(A % B);
                    break;
            }
        }
    }

}
