using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace File_Encoder {
    class Program {
        static void Main(string[] args) {
            StreamReader files;
            string[] fileNames;
            StreamWriter encryptedFiles;
            Random randnum = new Random(2);

            fileNames = Directory.GetFiles("Files");

            Console.WriteLine("Welcome.");
            Console.WriteLine("Encoding Files");

            //var timer = Stopwatch.StartNew();
            foreach (string fileName in fileNames) {
                try {

                    files = new StreamReader(fileName);

                    string message, encMess;

                    int matA, matB, matC, matD;

                    // Don't generate a singular matrix
                    do {
                        matA = randnum.Next(CharConvert.numChar);
                        matB = randnum.Next(CharConvert.numChar);
                        matC = randnum.Next(CharConvert.numChar);
                        matD = randnum.Next(CharConvert.numChar);
                    } while (((matA * matD) - (matB * matC)) != 1);

                    //Console.WriteLine("Encoding " + fileNames[i]);
                    message = files.ReadLine();

                    files.Close();

                    //var stopWatch = Stopwatch.StartNew();

                    // Encode the Message
                    encMess = Encoder.Encode(matA, matB, matC, matD, message);

                    //stopWatch.Stop();

                    encryptedFiles = new StreamWriter(fileName, false);

                    encryptedFiles.Write(encMess);

                    encryptedFiles.Close();
                    //Console.WriteLine("Done.");

                    //StreamWriter streamWriter = new StreamWriter("Times.txt", true);
                    //string totalTimeSt = "File Encode Time: " + stopWatch.ElapsedMilliseconds + " ms\n--------------\n";
                    //streamWriter.Write(totalTimeSt);
                    //streamWriter.Close();
                } catch (Exception e) {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            //timer.Stop();

            //StreamWriter streamWriter = new StreamWriter("Times.txt", true);
            //string totalTimeSt = "Total Time: " + timer.ElapsedMilliseconds + " ms\n--------------\n";
            //streamWriter.Write(totalTimeSt);
            //streamWriter.Close();
        }
    }
}
