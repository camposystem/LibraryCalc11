using System;
using Xunit;

namespace LibraryCalc11.test
{
    public class CalculadoraTests
    {
        [Theory]
        [InlineData(1,2)]
        public void SomaSucesso(int x, int y)
        {
         
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y);

            Assert.True((x + y) == resultado);

        }

        [Theory]
        [InlineData(1, 2,3)]
        public void SomaTresSucesso(int x, int y, int w)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.SomarTres(x, y,w);

            Assert.True((x + y+w) == resultado);

        }

        [Theory]
        [InlineData(1, 2)]
        public void SomaError(int x, int y)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y);

            Assert.False((x + y) != resultado);

        }

        [Theory]
        [InlineData(1, 2)]
        public void SubtrairSucesso(int x, int y)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.Subtrair(x, y);

            Assert.True((x - y) == resultado);

        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void SubtrairTresSucesso(int x, int y, int w)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.SubtrairTres(x, y, w);

            Assert.True((x + y + w) == resultado);

        }
        [Theory]
        [InlineData(1, 2)]
        public void MultiplicarSucesso(int x, int y)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.Mutiplicar(x, y);

            Assert.True((x * y) == resultado);

        }
        [Theory]
        [InlineData(1, 2)]
        public void DividirSucesso(int x, int y)
        {

            var calculadora = new Calculadora();

            var resultado = calculadora.Dividir(x, y);

            Assert.True((x / y) == resultado);

        }
    }
}
