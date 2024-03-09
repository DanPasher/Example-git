using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptación_y_Desencriptación_1._0
{
    internal class Program
    {
        static Dictionary<char, char> mapeoEncriptacion = new Dictionary<char, char>();
        static Dictionary<char, char> mapeoDesencriptacion = new Dictionary<char, char>();

            static void Main()
            {
                try
                {
                    // Definir el mapeo de encriptación y desencriptación
                    EstablecerMapeo('a', '3');
                    EstablecerMapeo('b', '8');
                    EstablecerMapeo('c', 'L');
                    EstablecerMapeo('d', 'F');
                    EstablecerMapeo('e', '5');
                    EstablecerMapeo('f', '7');
                    EstablecerMapeo('g', 'y');
                    EstablecerMapeo('h', '0');
                    EstablecerMapeo('i', ';');
                    EstablecerMapeo('j', 'q');
                    EstablecerMapeo('k', 'T');
                    EstablecerMapeo('l', 'Q');
                    EstablecerMapeo('m', 'W');
                    EstablecerMapeo('n', 'R');
                    EstablecerMapeo('o', 'O');
                    EstablecerMapeo('p', 'I');
                    EstablecerMapeo('q', 'j');
                    EstablecerMapeo('r', '.');
                    EstablecerMapeo('s', '+');
                    EstablecerMapeo('t', '_');
                    EstablecerMapeo('u', '/');
                    EstablecerMapeo('v', '}');
                    EstablecerMapeo('w', '{');
                    EstablecerMapeo('x', '-');
                    EstablecerMapeo('y', 'g');
                    EstablecerMapeo('z', '&');
                    EstablecerMapeo('1', '#');
                    EstablecerMapeo('2', 'U');
                    EstablecerMapeo('3', 'a');
                    EstablecerMapeo('4', 'M');
                    EstablecerMapeo('5', 'e');
                    EstablecerMapeo('6', 'S');
                    EstablecerMapeo('7', 'f');
                    EstablecerMapeo('8', 'b');
                    EstablecerMapeo('9', 'r');
                    EstablecerMapeo('A', 'B');
                    EstablecerMapeo('B', 'A');
                    EstablecerMapeo('C', '$');
                    EstablecerMapeo('D', 'ñ');
                    EstablecerMapeo('E', 'J');
                    EstablecerMapeo('F', 'd');
                    EstablecerMapeo('G', '=');
                    EstablecerMapeo('H', '>');
                    EstablecerMapeo('I', 'p');
                    EstablecerMapeo('J', 'E');
                    EstablecerMapeo('K', 'V');
                    EstablecerMapeo('L', 'c');
                    EstablecerMapeo('M', '4');
                    EstablecerMapeo('N', '[');
                    EstablecerMapeo('O', 'o');
                    EstablecerMapeo('P', '?');
                    EstablecerMapeo('Q', 'l');
                    EstablecerMapeo('R', 'n');
                    EstablecerMapeo('S', '6');
                    EstablecerMapeo('T', 'k');
                    EstablecerMapeo('U', '2');
                    EstablecerMapeo('V', 'K');
                    EstablecerMapeo('W', 'm');
                    EstablecerMapeo('X', 'Y');
                    EstablecerMapeo('Y', 'X');
                    EstablecerMapeo('Z', '@');
                    EstablecerMapeo('_', 't');
                    EstablecerMapeo('@', 'Z');
                    EstablecerMapeo('&', 'z');
                    EstablecerMapeo('!', '¿');
                    EstablecerMapeo('0','h');
                    EstablecerMapeo('.', 'r');
                    EstablecerMapeo('+', 's');
                    EstablecerMapeo('/', 'u');
                    EstablecerMapeo('}', 'v');
                    EstablecerMapeo('{', 'w');
                    EstablecerMapeo('-', 'x');
                    EstablecerMapeo('#', '1');
                    EstablecerMapeo('$', 'C');
                // Pedir al usuario que ingrese la contraseña
                Console.WriteLine("Ingrese su contraseña:");
                    string contraseñaOriginal = Console.ReadLine();

                    // Encriptar la contraseña
                    string contraseñaEncriptada = EncriptarContraseña(contraseñaOriginal);
                    Console.WriteLine("Contraseña encriptada: " + contraseñaEncriptada);

                    // Desencriptar la contraseña
                    string contraseñaDesencriptada = DesencriptarContraseña(contraseñaEncriptada);
                    Console.WriteLine("Contraseña desencriptada: " + contraseñaDesencriptada); 
                    Console.Read();
            }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo un error: " + ex.Message);
                }
            }

            static void EstablecerMapeo(char caracterOriginal, char caracterEncriptado)
            {
                mapeoEncriptacion[caracterOriginal] = caracterEncriptado;
                mapeoDesencriptacion[caracterEncriptado] = caracterOriginal;
            }

            static string EncriptarContraseña(string contraseña)
            {
                char[] arregloContraseña = contraseña.ToCharArray();

                // Encriptar cada carácter de la contraseña
                for (int i = 0; i < arregloContraseña.Length; i++)
                {
                    if (mapeoEncriptacion.ContainsKey(arregloContraseña[i]))
                    {
                        arregloContraseña[i] = mapeoEncriptacion[arregloContraseña[i]];
                    }
                }

                // Convertir el arreglo de caracteres en una cadena y devolverla
                return new string(arregloContraseña);
            }

            static string DesencriptarContraseña(string contraseñaEncriptada)
            {
                char[] arregloContraseña = contraseñaEncriptada.ToCharArray();

                // Desencriptar cada carácter de la contraseña
                for (int i = 0; i < arregloContraseña.Length; i++)
                {
                    if (mapeoDesencriptacion.ContainsKey(arregloContraseña[i]))
                    {
                        arregloContraseña[i] = mapeoDesencriptacion[arregloContraseña[i]];
                    }
                }

                // Convertir el arreglo de caracteres en una cadena y devolverla
                return new string(arregloContraseña);
            
            }
      
        }
           


    }