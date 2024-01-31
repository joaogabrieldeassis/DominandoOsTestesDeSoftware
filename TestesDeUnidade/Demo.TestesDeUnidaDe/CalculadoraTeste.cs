using DemoTestes;

namespace Demo.TestesDeUnidaDe
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Calculadora_Somar_RetornarSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(3, 3);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(2, 1, 2)]
        [InlineData(200, 2, 100)]
        [InlineData(100, 2, 50)]
        public void Calculadora_Dividir_RetornarDivisao(int valor1, int valor2, double valorEsperado)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(valor1, valor2);

            //Assert
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
