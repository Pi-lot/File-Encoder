using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace File_Encoder {
    static class Encoder {
        /// <summary>
        /// Encode a message with a 2x2 matrix with the given elements
        /// </summary>
        /// <param name="matA">a element of the Matrix</param>
        /// <param name="matB">b element of the Matrix</param>
        /// <param name="matC">c element of the Matrix</param>
        /// <param name="matD">d element of the Matrix</param>
        /// <param name="message">The Message to be encoded</param>
        /// <returns>Encoded version of message</returns>
        public static string Encode(int matA, int matB, int matC, int matD, string message) {
            Random randnum = new Random();

            // Generate a blank list to store the converted string into.
            List<int> numbers = new List<int>();

            // Convert and add the number to the list of numbers.
            foreach (char letter in message) {
                int num = CharConvert.LetterToNumber(letter);
                numbers.Add(num);
            }

            // Create the variables used to multiply my the matrix.
            int numOne, numTwo;

            //var stopWatch = Stopwatch.StartNew();

            // Look at pairs of numbers in the list and multiply them by the matrix
            // then remove the old numbers and add the new numbers.
            // Repeat for half the number of items originally in list.
            for (int i = 0; i < (numbers.Count / 2); i++) {
                numOne = ((numbers[0] * matA) + (numbers[1] * matB)) % CharConvert.numChar;
                numTwo = ((numbers[0] * matC) + (numbers[1] * matD)) % CharConvert.numChar;
                numbers.RemoveAt(0);
                numbers.RemoveAt(0);
                numbers.Add(numOne);
                numbers.Add(numTwo);
            }
            //stopWatch.Stop();

            //StreamWriter sw = new StreamWriter("Times.txt", true);
            //string time = "Matrix Time: " + stopWatch.ElapsedMilliseconds + " ms\n";
            //sw.Write(time);
            //sw.Close();

            // Check if the original message had odd characters. If true add a character
            // that is an odd number, otherwise add an even number. (at the end)
            // Then matrix multiply.
            if (numbers.Count % 2 != 0) {
                numOne = ((numbers[0] * matA) + (numbers[0] * matB)) % CharConvert.numChar;
                numTwo = ((numbers[0] * matC) + (numbers[0] * matD)) % CharConvert.numChar;
                numbers.RemoveAt(0);
                numbers.Add(numOne);
                numbers.Add(numTwo);

                int oddID = randnum.Next(0, CharConvert.numChar);
                while (oddID % 2 == 0) {
                    oddID = randnum.Next(0, CharConvert.numChar);
                }
                numbers.Add(oddID);
            } else {
                int evenID = randnum.Next(0, CharConvert.numChar);
                while (evenID % 2 != 0) {
                    evenID = randnum.Next(0, CharConvert.numChar);
                }
                numbers.Add(evenID);
            }

            // Used to store the characters (as strings) when converted back from numbers.
            List<string> encoded = new List<string>();

            // Convert the numbers back into letters.
            foreach (int number in numbers) {
                string letter = CharConvert.NumberToLetter(number);
                encoded.Add(letter);
            }
            numbers.Clear();

            // Put the characters (as strings) into a single line string.
            StringBuilder joiner = new StringBuilder();
            foreach (string character in encoded) {
                joiner.Append(character);
            }
            encoded.Clear();

            // Put all the encoded message pieces together and return the value.
            string encMess = CharConvert.NumberToLetter(matA) + CharConvert.NumberToLetter(matB)
                + CharConvert.NumberToLetter(matC) + CharConvert.NumberToLetter(matD) + joiner.ToString();
            joiner.Clear();

            return encMess;
        }
    }
}
