using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Morsekode";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a message to encode in Morse code:");
                string message = Console.ReadLine().ToUpper(); // Convert the message to uppercase

                string morseCode = EncodeToMorse(message);
                Console.WriteLine("Morse Code: " + morseCode);

                Console.ReadLine();
            }
        }

        static string EncodeToMorse(string message)
        {
            string morseCode = "";

            foreach (char c in message)
            {
                // Use a switch statement to map characters to Morse code
                switch (c)
                {
                    case 'A':
                        morseCode += ".- ";
                        break;
                    case 'B':
                        morseCode += "-... ";
                        break;
                    case 'C':
                        morseCode += "-.-. ";
                        break;
                    case 'D':
                        morseCode += "— · · ";
                        break;
                    case 'E':
                        morseCode += "· ";
                        break;
                    case 'F':
                        morseCode += "· · — · ";
                        break;
                    case 'G':
                        morseCode += "— — · ";
                        break;
                    case 'H':
                        morseCode += "· · · ·  ";
                        break;
                    case 'I':
                        morseCode += "· · ";
                        break;
                    case 'J':
                        morseCode += "· — — — ";
                        break;
                    case 'K':
                        morseCode += "— · — ";
                        break;
                    case 'L':
                        morseCode += "· — · · ";
                        break;
                    case 'N':
                        morseCode += "— · ";
                        break;
                    case 'M':
                        morseCode += "— — ";
                        break;
                    case 'O':
                        morseCode += "— — — ";
                        break;
                    case 'P':
                        morseCode += "· — — · ";
                        break;
                    case 'Q':
                        morseCode += "— — · — ";
                        break;
                    case 'R':
                        morseCode += "· — ·  ";
                        break;
                    case 'S':
                        morseCode += "· · · ";
                        break;
                    case 'T':
                        morseCode += "— ";
                        break;
                    case 'U':
                        morseCode += "· · — ";
                        break;
                    case ' ':
                        morseCode += "   "; // Space between words
                        break;
                    default:
                        morseCode += c; // If character is not recognized, keep it as is
                        break;
                }
            }

            return morseCode;
        }
    }
}
