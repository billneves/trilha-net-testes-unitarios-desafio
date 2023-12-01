using Xunit;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "Matrix";
            var resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Os outros métodos de teste seguem um padrão semelhante.
        // Certifique-se de substituir os TODOs pelos códigos de teste adequados.
    }
}
