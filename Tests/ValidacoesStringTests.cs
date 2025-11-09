using Xunit;
using TestesUnitarios.Desafio.Console;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            var texto = "Matrix";
            var qtd = ValidacoesString.QuantidadeCaracteres(texto);
            Assert.Equal(6, qtd);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var contem = ValidacoesString.ContemCaractere(texto, "qualquer");
            Assert.True(contem);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var contem = ValidacoesString.ContemCaractere(texto, "teste");
            Assert.False(contem);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            var texto = "Começo, meio e fim do texto procurado";
            var termina = ValidacoesString.TextoTerminaCom(texto, "procurado");
            Assert.True(termina);
        }
    }
}