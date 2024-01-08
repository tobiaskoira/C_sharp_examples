
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;


//Decription
/*Use delegates to make a program for the user to enter a string. After that, the user can choose one or more actions to be performed on the string.
You must be able to perform the following operations on a character string:

converts all letters in a string to uppercase
converts all letters in a string to lowercase
changes the Title style of the string, i.e. the first character is uppercase and the rest are lowercase
reverses the string, i.e. the word Teppo becomes oppeT.

That is, implement your own method for each transformation (all methods must have the same signature). Create an instance of the delegate and attach the necessary methods to it.Voilá.
*/
namespace Changing_style_of_string
{
    class DelegaattiDemo
    {
        private static List<string> treatmentElements;

        delegate void FormatoiWord(string word);

        public static void Main(string[] args)
        {

            List<string> numbersInput = new List<string>();

            //kysytään käyttäjältä jokin sano
            Console.WriteLine("Enter the string to process:");
            string syote = Console.ReadLine();

            numbersInput.Add(syote);

            while (syote != "")
            {

                Console.WriteLine("Choose the treatment you want, " +
                "you can give several treatments at once\r\nas one string, e.g. '123'\r\n1: " +
                "to capital letters\r\n2: lowercase\r\n3: " +
                "as a title\r\n4: as a palindrome");
                string treatment = Console.ReadLine();

                List<string> treatmentInput = new List<string>();
                treatmentInput.Add(treatment);


                // format = WriteLetters;
                //format(treatment);

                foreach (char t in treatment)
                {
                    Console.WriteLine(t);
                    if (t.ToString().Contains('1'))
                    {
                        //kiinnitetään useita metodeja delegaatille
                        FormatoiWord formatoija = FormatoiCapital;

                        //kutsutaan kiinnitetyt delegaatit
                        formatoija(syote);
                    }
                    if (t.ToString().Contains('2'))
                    {
                        //kiinnitetään useita metodeja delegaatille
                        FormatoiWord formatoija = FormatoiLowercase;

                        //kutsutaan kiinnitetyt delegaatit
                        formatoija(syote);
                    }
                    if (t.ToString().Contains('3'))
                    {
                        //kiinnitetään useita metodeja delegaatille
                        FormatoiWord formatoija = FormatoiTitle;

                        //kutsutaan kiinnitetyt delegaatit
                        formatoija(syote);
                    }
                    if (t.ToString().Contains('4'))
                    {
                        //kiinnitetään useita metodeja delegaatille
                        FormatoiWord formatoija = FormatoiPalindrome;

                        //kutsutaan kiinnitetyt delegaatit
                        formatoija(syote);
                    }

                }



                Console.WriteLine("Please enter another string: ");

            }




        }



        //metodit


        static void FormatoiCapital(string word)
        {
            Console.WriteLine(word.ToUpper());
        }

        static void FormatoiLowercase(string word)
        {
            Console.WriteLine(word.ToLower());
        }

        static void FormatoiTitle(string word)
        {
            Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(word.ToLower()));
        }

        static void FormatoiPalindrome(string word)
        {
            string _reversestr = string.Empty;
            if (word != null)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    word += word[i].ToString();
                    _reversestr += word[i].ToString();
                    // Console.WriteLine(_reversestr);
                }
                Console.WriteLine(_reversestr);

            }
        }


    }
}
