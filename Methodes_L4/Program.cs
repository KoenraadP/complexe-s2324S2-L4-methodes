﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = '1'; // false
            char second = 'a'; // false
            char third = 'b'; // true

            // controleren of first een medeklinker is
            /*if (IsConsonant(first))
            {
                // als de methode 'true' uitkomt
                Console.WriteLine(first +
                    " is een medeklinker");
            }
            else
            {
                // als de methode 'false' uitkomt
                Console.WriteLine(first +
                    " is geen medeklinker");
            }*/

            // alternatief met ?
            Console.WriteLine(IsConsonant(first) ?
                first + " is een medeklinker" :
                first + " is geen medeklinker");

            Console.WriteLine(IsConsonant(second) ?
                second + " is een medeklinker" :
                second + " is geen medeklinker");

            Console.WriteLine(IsConsonant(third) ?
                third + " is een medeklinker" :
                third + " is geen medeklinker");

            // uittesten van Refund methode
            Console.WriteLine(Refund(10, 5)); // te veel betaald
            Console.WriteLine(Refund(5, 10)); // te weinig betaald
            Console.WriteLine(Refund(10, 10)); // exact genoeg betaald
        }

        // methode om te checken of een
        // opgegeven karakter een medeklinker is
        private static bool IsConsonant(char c)
        {
            // array maken met alle medeklinkers
            char[] consonants = {'b','c','d','f','g','h','j','k',
            'l','m','n','p','q','r','s','t','v','w','x','z'};

            // parameter c vergelijken met 
            // alle waarden in de array
            foreach (char consonant in consonants)
            {
                // methode stoppen en true geven als waarde
                // wanneer een match gevonden wordt
                if (c == consonant) return true;
            }

            // als er geen match gevonden werd, return false
            return false;
        }

        // methode die aangeeft of een klant
        // genoeg, te weinig of te veel betaald heeft
        // en wat de kassier eventueel nog moet teruggeven
        // paid = wat heeft de klant betaald
        // cost = wat kost het product
        private static string Refund(decimal paid, decimal cost)
        {
            // als de klant exact correct betaald heeft
            if (paid == cost)
            {
                return "Geen terugbetaling nodig";
            }

            // als de klant te veel betaald heeft
            if (paid > cost)
            {
                // hoe veel moet de klant terug krijgen
                decimal refund = paid - cost;
                return "De kassier moet " + refund + " terugbetalen.";
            }

            // als de klant te weinig betaald heeft
            // hoe veel moet de klant nog betalen
            decimal extra = cost - paid;
            return "De klant moet nog " + extra + " betalen";
        }
    }
}
