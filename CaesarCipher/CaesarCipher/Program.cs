using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string message;

            Console.WriteLine("Please enter the secret message: ");
            message = Console.ReadLine().ToLower();

            char[] secretMessage = message.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];
            
            for(int i = 0; i < secretMessage.Length; i++)
            {
                char charSecretMessage = secretMessage[i];

                //find the letter position in the array alphabet.
                //Note: we need to use the modulo because of the cases in which we have a 'z' letter, otherwise, it will expand the limit of the alphabet when we add the 3 positions to the right(it would be 28 letters).
                //This way, we make sure that the letter position will never go past 26
                int letterPosition = (Array.IndexOf(alphabet, charSecretMessage) + 3) % 26;
                char encryptedChar = alphabet[letterPosition];

                encryptedMessage[i] = encryptedChar;

                

            }

            string finalMessage = String.Join("", encryptedMessage);
            Console.WriteLine(finalMessage);

        }
    }
}
