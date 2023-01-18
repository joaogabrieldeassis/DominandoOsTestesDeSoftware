using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    public class CalculadoraTets
    {
        [Fact]
        public void Calculadora_Multiplicar_RetornarResultados()
        {
            //Arrange
            var calculadores = new Calculadora();

            //Act
            var resultado = calculadores.Multiplicar(2, 2);

            //Assert
            Assert.Equal(4,resultado);
        }
        [Fact]
        public void Calculadores_Dividir_RetornarOresultadoDaDivisao()
        {
            //Arrange 
            var calculadora = new Calculadora();

            //Act 
            var resultado = calculadora.Dividir(2,2);

            //Assert
            Assert.Equal(4, resultado);
        }
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3,3,9)]
        [InlineData(10,10,10)]
        [InlineData(5,5,25)]
        public void Calculadora_Multiplicar_RetornarResultadosTheory(double v1, double v2, double total)
        {
            //Arrange
            var calculadores = new Calculadora();

            //Act
            var resultado = calculadores.Multiplicar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
