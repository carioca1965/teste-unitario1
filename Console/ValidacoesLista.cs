using System;
using System.Collections.Generic;
using System.Linq;

namespace TestesUnitarios.Desafio.Console
{
    public static class ValidacoesLista
    {
        public static List<int> RemoverNumerosNegativos(List<int> numeros)
        {
            if (numeros == null) return new List<int>();
            return numeros.Where(n => n >= 0).ToList();
        }

        public static bool ListaContemDeterminadoNumero(List<int> numeros, int numero)
        {
            if (numeros == null) return false;
            return numeros.Contains(numero);
        }

        public static List<int> MultiplicarNumerosLista(List<int> numeros, int multiplicador)
        {
            if (numeros == null) return new List<int>();
            return numeros.Select(n => n * multiplicador).ToList();
        }

        public static int RetornarMaiorNumero(List<int> numeros)
        {
            if (numeros == null || numeros.Count == 0)
                throw new ArgumentException("A lista deve conter ao menos um elemento.");
            return numeros.Max();
        }

        public static int RetornarMenorNumero(List<int> numeros)
        {
            if (numeros == null || numeros.Count == 0)
                throw new ArgumentException("A lista deve conter ao menos um elemento.");
            return numeros.Min();
        }
    }
}