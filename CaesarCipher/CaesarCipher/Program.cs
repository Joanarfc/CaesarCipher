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

            Menu();

        }

        static void Menu()
        {
            Console.WriteLine("***********Choose one of the following actions (options 1-2): ***********");
            Console.WriteLine("1 - Encrypt a message");
            Console.WriteLine("2 - Decrypt a message \n ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string encryptedMessage = EncryptMessage(InputMessageToChar(), 3);
                    Console.WriteLine(encryptedMessage);
                    break;
                case "2":
                    string decryptedsecretMessage = DecryptMessage(InputMessageToChar(), 3);
                    Console.WriteLine(decryptedsecretMessage);
                    break;


            }
        }

        static char[] InputMessageToChar()
        {
            string message;

            Console.WriteLine("Please enter the secret message: ");
            message = Console.ReadLine().ToLower();


            return message.ToCharArray();
        }

        static string EncryptMessage(char[] message, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] encryptedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char charSecretMessage = message[i];

                if (Array.IndexOf(alphabet, charSecretMessage) != -1)
                {
                    //find the letter position in the array alphabet.
                    //Note: we need to use the modulo because of the cases in which we have a 'z' letter, otherwise, it will expand the limit of the alphabet when we add the 3 positions to the right(it would be 28 letters).
                    //This way, we make sure that the letter position will never go further than 26
                    int letterPosition = (Array.IndexOf(alphabet, charSecretMessage) + key) % alphabet.Length;
                    encryptedMessage[i] = alphabet[letterPosition];

                }
                else
                {
                    encryptedMessage[i] = message[i];

                }

            }
            string finalMessage = String.Join("", encryptedMessage);
            return finalMessage;

        }

        static string DecryptMessage(char[] message, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] encryptedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char charSecretMessage = message[i];

                if (Array.IndexOf(alphabet, charSecretMessage) != -1)
                {
                    //find the letter position in the array alphabet.
                    //Note: we need to use the modulo because of the cases in which we have a 'z' letter, otherwise, it will expand the limit of the alphabet when we add the 3 positions to the right(it would be 28 letters).
                    //This way, we make sure that the letter position will never go further than 26
                    int letterPosition = (Array.IndexOf(alphabet, charSecretMessage) - key) % alphabet.Length;
                    encryptedMessage[i] = alphabet[letterPosition];

                }
                else
                {
                    encryptedMessage[i] = message[i];

                }

            }
            string finalMessage = String.Join("", encryptedMessage);
            return finalMessage;

        }
    }
}
