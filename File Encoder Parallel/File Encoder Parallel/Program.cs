using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace File_Encoder_Parallel {
    class Program {
        const int NUM_THREADS = 6;
        static StreamReader[] files;
        static string[] fileNames;
        static float totalTime = 0.0f;
        static int[] matA, matB, matC, matD;

        static void Main(string[] args) {
            Random randnum = new Random(2);
            StreamWriter[] encryptedFiles;

            fileNames = Directory.GetFiles("Files");

            files = new StreamReader[fileNames.Length];
            encryptedFiles = new StreamWriter[fileNames.Length];

            for (int i = 0; i < files.Length; i++) {
                files[i] = new StreamReader(fileNames[i]);
            }

            matA = new int[fileNames.Length];
            matB = new int[fileNames.Length];
            matC = new int[fileNames.Length];
            matD = new int[fileNames.Length];

            Console.WriteLine("Welcome.");
            Console.WriteLine("Encoding Files");

            // Place here for comparison purposes (so the matrices are generated in the same order as non-parallel)
            for (int i = 0; i < fileNames.Length; i++) {
                // Don't generate a singular matrix
                do {
                    matA[i] = randnum.Next(CharConvert.numChar);
                    matB[i] = randnum.Next(CharConvert.numChar);
                    matC[i] = randnum.Next(CharConvert.numChar);
                    matD[i] = randnum.Next(CharConvert.numChar);
                } while (((matA[i] * matD[i]) - (matB[i] * matC[i])) != 1);
            }

            var noThreads = new ParallelOptions() { MaxDegreeOfParallelism = NUM_THREADS };

            var time = Stopwatch.StartNew();

            Parallel.For(0, fileNames.Length, i => {
                try {
                    string message, encMess;

                    //Console.WriteLine("Encoding {0} ", fileNames[i]);
                    message = files[i].ReadLine();

                    // Encode the Message
                    encMess = Encoder.Encode(matA[i], matB[i], matC[i], matD[i], message);

                    files[i].Close();

                    encryptedFiles[i] = new StreamWriter(fileNames[i], false);

                    encryptedFiles[i].Write(encMess);

                    encryptedFiles[i].Close();
                    //Console.WriteLine("Finished {0}", fileNames[i]);
                } catch (Exception e) {
                    Console.WriteLine("Exception for " + fileNames[i] + ": " + e.Message);
                }
            });

            //for (int i = 0; i < fileNames.Length; i++) {
            //    try {
            //        string message, encMess;

            //        //Console.WriteLine("Encoding {0} ", fileNames[i]);
            //        message = files[i].ReadLine();

            //        // Encode the Message
            //        encMess = Encoder.Encode(matA[i], matB[i], matC[i], matD[i], message);

            //        files[i].Close();

            //        encryptedFiles[i] = new StreamWriter(fileNames[i], false);

            //        encryptedFiles[i].Write(encMess);

            //        encryptedFiles[i].Close();
            //        //Console.WriteLine("Finished {0}", fileNames[i]);
            //    } catch (Exception e) {
            //        Console.WriteLine("Exception for " + fileNames[i] + ": " + e.Message);
            //    }
            //}
            time.Stop();

            totalTime = time.ElapsedMilliseconds;

            StreamWriter streamWriter = new StreamWriter("Times.txt", true);
            string totalTimeSt = "Total Time: " + totalTime + " ms\n--------------\n";
            streamWriter.Write(totalTimeSt);
            streamWriter.Close();
        }
    }
}
