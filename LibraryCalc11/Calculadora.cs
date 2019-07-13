using System;

namespace LibraryCalc11
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        ///  Metodo que realizza divisão entre dois numeros.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Dividir(int x, int y)
        {
            if (x < y)
            {
                return 0;
            }
            else
            {
                return x / y;
            }

        }
        /// <summary>
        /// Metodo que realiza a multiplicação entre dois numeros.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Mutiplicar(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Metodo que realiza a soma entre dois numero.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Soma(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Metodo para somar 3 numeros.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        public int SomarTres(int x, int y, int w)
        {
            return x + y + w;
        }

        /// <summary>
        /// Metodo que realiza a subtração entre dois numeros.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public int SubtrairTres(int x, int y, int w)
        {
            return ((x-y)-w);
        }
    }
}
