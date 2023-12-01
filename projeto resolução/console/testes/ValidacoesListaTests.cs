using System.Collections.Generic;
using Xunit;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Os outros métodos de teste seguem um padrão semelhante.
        // Certifique-se de substituir os TODOs pelos códigos de teste adequados.
    }
}
