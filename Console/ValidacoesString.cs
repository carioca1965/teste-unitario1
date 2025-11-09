using System;

namespace TestesUnitarios.Desafio.Console
{
    public static class ValidacoesString
    {
        public static int QuantidadeCaracteres(string texto)
        {
            if (texto == null) return 0;
            return texto.Length;
        }

        public static bool ContemCaractere(string texto, string trecho)
        {
            if (texto == null || trecho == null) return false;
            return texto.Contains(trecho);
        }

        public static bool TextoTerminaCom(string texto, string trecho)
        {
            if (texto == null || trecho == null) return false;
            return texto.EndsWith(trecho);
        }
    }
}