using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegularesI
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = "Mi nombre es Juan y mi n1 de tfno es (+34) 123-45-67 y mi codigo postal es 29679";

            string patron = "[J]";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado una J");
            else Console.WriteLine("No se ha encontrado");
        }
    }
}
