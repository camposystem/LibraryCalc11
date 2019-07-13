using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc11
{
   public interface ICalculadora
    {
        /// <summary>
        ///  interface para o comportamento de soma.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Soma(int x, int y);
        /// <summary>
        ///  interfacce para o comportamento de subtração
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Subtrair(int x, int y);
        /// <summary>
        /// interface para o comportamento de multiplicação
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Mutiplicar(int x, int y);
        /// <summary>
        /// interface para o comportamento de divisão.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        double Dividir(int x, int y);
        /// <summary>
        /// interface para o comportamento de somar 3 numeros;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        int SomarTres(int x, int y, int w);
    }
}
