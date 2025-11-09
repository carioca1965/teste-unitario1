using System;
using System.Collections.Generic;
using Xunit;
using TestesUnitarios.Desafio.Console;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesListaTests
    {
        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            var lista = new List<int> { -5, 0, 3, -1, 7 };
            var resultado = ValidacoesLista.RemoverNumerosNegativos(lista);
            Assert.DoesNotContain(resultado, n => n < 0);
            Assert.Equal(new List<int> {0, 3, 7}, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            var lista = new List<int> { 1, 9, 3, 7 };
            var contem = ValidacoesLista.ListaContemDeterminadoNumero(lista, 9);
            Assert.True(contem);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 1, 2, 3, 4 };
            var contem = ValidacoesLista.ListaContemDeterminadoNumero(lista, 10);
            Assert.False(contem);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            var lista = new List<int> { 1, 2, 3 };
            var resultado = ValidacoesLista.MultiplicarNumerosLista(lista, 2);
            Assert.Equal(new List<int> { 2, 4, 6 }, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            var lista = new List<int> { 5, 9, 3, 7 };
            var maior = ValidacoesLista.RetornarMaiorNumero(lista);
            Assert.Equal(9, maior);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            var lista = new List<int> { -8, 0, 2, 5 };
            var menor = ValidacoesLista.RetornarMenorNumero(lista);
            Assert.Equal(-8, menor);
        }
    }
}