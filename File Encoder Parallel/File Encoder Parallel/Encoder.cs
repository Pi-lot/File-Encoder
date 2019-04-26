using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Encoder_Parallel {
    static class Encoder {
        /// <summary>
        /// Logic for encoding a message and giving the keys inside the message.
        /// </summary>
        /// <param name="matA"></param>
        /// <param name="matB"></param>
        /// <param name="matC"></param>
        /// <param name="matD"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Encode(int matA, int matB, int matC, int matD, string message) {
            Random randnum = new Random();

            // Generate a blank list to store the converted string into.
            List<int> numbers = new List<int>();
            List<int> encodedNumbers = new List<int>();

            // Convert and add the number to the list of numbers.
            foreach (char letter in message) {
                int num = CharConvert.LetterToNumber(letter);
                numbers.Add(num);
            }

            // Create the variables used to multiply my the matrix.
            int numOne, numTwo;

            // Look at pairs of numbers in the list and multiply them by the matrix
            // then remove the old numbers and add the new numbers.
            // Repeat for half the number of items originally in list.
            for (int i = 0; i < numbers.Count - 1; i += 2) {
                numOne = ((numbers[i] * matA) + (numbers[i + 1] * matB)) % CharConvert.numChar;
                numTwo = ((numbers[i] * matC) + (numbers[i + 1] * matD)) % CharConvert.numChar;
                encodedNumbers.Add(numOne);
                encodedNumbers.Add(numTwo);
            }

            // Check if the original message had odd characters. If true add a character
            // that is an odd number, otherwise add an even number. (at the end)
            // Then matrix multiply.
            if (numbers.Count % 2 != 0) {
                numOne = ((numbers[numbers.Count - 1] * matA) + (numbers[numbers.Count - 1] * matB)) % CharConvert.numChar;
                numTwo = ((numbers[numbers.Count - 1] * matC) + (numbers[numbers.Count - 1] * matD)) % CharConvert.numChar;
                encodedNumbers.Add(numOne);
                encodedNumbers.Add(numTwo);

                int oddID;
                do {
                    oddID = randnum.Next(0, CharConvert.numChar);
                } while (oddID % 2 == 0);
                encodedNumbers.Add(oddID);
            } else {
                int evenID;
                do {
                    evenID = randnum.Next(0, CharConvert.numChar);
                } while (evenID % 2 != 0);
                encodedNumbers.Add(evenID);
            }

            // Used to store the characters (as strings) when converted back from numbers.
            List<string> encoded = new List<string>();

            // Convert the numbers back into letters.
            foreach (int number in encodedNumbers) {
                string letter = CharConvert.NumberToLetter(number);
                encoded.Add(letter);
            }
            numbers.Clear();
            encodedNumbers.Clear();

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
