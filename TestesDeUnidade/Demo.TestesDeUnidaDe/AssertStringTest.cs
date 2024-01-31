using DemoTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.TestesDeUnidaDe
{
    public class AssertStringTest
    {
        [Fact]
        public void StringTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange 
            var tools = new StringTools();

            // Act
            var result = tools.Unir("Joao", "Gabriel");

            // Assert
            Assert.Equal("Joao Gabriel", result);
        }

        
        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Joao", "Gabriel");

            // Assert
            Assert.Contains("ao", nomeCompleto);
        }


        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Sei la", "la");

            // Assert
            Assert.StartsWith("Sei", nomeCompleto);
        }


        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            // Assert
            Assert.EndsWith("res", nomeCompleto);
        }


        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringTools();

            // Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
