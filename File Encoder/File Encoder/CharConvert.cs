using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Encoder {
    static class CharConvert {
        public static int numChar = 95; // Store the number of characters that can be converted

        // <summary>
        /// Converts individual characters to numbers.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public static int LetterToNumber(char character) {
            string letter = character.ToString();
            // Lower case Letters
            if (letter == "a") {
                return 44;
            } else if (letter == "b") {
                return 87;
            } else if (letter == "c") {
                return 12;
            } else if (letter == "d") {
                return 13;
            } else if (letter == "e") {
                return 89;
            } else if (letter == "f") {
                return 59;
            } else if (letter == "g") {
                return 83;
            } else if (letter == "h") {
                return 34;
            } else if (letter == "i") {
                return 63;
            } else if (letter == "j") {
                return 55;
            } else if (letter == "k") {
                return 58;
            } else if (letter == "l") {
                return 78;
            } else if (letter == "m") {
                return 17;
            } else if (letter == "n") {
                return 61;
            } else if (letter == "o") {
                return 94;
            } else if (letter == "p") {
                return 68;
            } else if (letter == "q") {
                return 2;
            } else if (letter == "r") {
                return 81;
            } else if (letter == "s") {
                return 46;
            } else if (letter == "t") {
                return 30;
            } else if (letter == "u") {
                return 29;
            } else if (letter == "v") {
                return 16;
            } else if (letter == "w") {
                return 36;
            } else if (letter == "x") {
                return 56;
            } else if (letter == "y") {
                return 11;
            } else if (letter == "z") {
                return 21;
            }

              // Upper Case Letters
              else if (letter == "A") {
                return 39;
            } else if (letter == "B") {
                return 41;
            } else if (letter == "C") {
                return 77;
            } else if (letter == "D") {
                return 14;
            } else if (letter == "E") {
                return 67;
            } else if (letter == "F") {
                return 48;
            } else if (letter == "G") {
                return 92;
            } else if (letter == "H") {
                return 15;
            } else if (letter == "I") {
                return 91;
            } else if (letter == "J") {
                return 9;
            } else if (letter == "K") {
                return 93;
            } else if (letter == "L") {
                return 64;
            } else if (letter == "M") {
                return 80;
            } else if (letter == "N") {
                return 75;
            } else if (letter == "O") {
                return 22;
            } else if (letter == "P") {
                return 53;
            } else if (letter == "Q") {
                return 26;
            } else if (letter == "R") {
                return 42;
            } else if (letter == "S") {
                return 76;
            } else if (letter == "T") {
                return 45;
            } else if (letter == " ") {
                return 66;
            } else if (letter == "V") {
                return 35;
            } else if (letter == "W") {
                return 47;
            } else if (letter == "X") {
                return 31;
            } else if (letter == "Y") {
                return 33;
            } else if (letter == "Z") {
                return 7;
            }

              // Numbers
              else if (letter == "1") {
                return 19;
            } else if (letter == "2") {
                return 10;
            } else if (letter == "3") {
                return 65;
            } else if (letter == "4") {
                return 51;
            } else if (letter == "5") {
                return 60;
            } else if (letter == "6") {
                return 79;
            } else if (letter == "7") {
                return 85;
            } else if (letter == "8") {
                return 74;
            } else if (letter == "9") {
                return 38;
            } else if (letter == "0") {
                return 27;
            }

              // Other Characters
              else if (letter == "\"") {
                return 52;
            } else if (letter == "'") {
                return 40;
            } else if (letter == "!") {
                return 69;
            } else if (letter == "?") {
                return 43;
            } else if (letter == ".") {
                return 86;
            } else if (letter == ",") {
                return 57;
            } else if (letter == ":") {
                return 50;
            } else if (letter == ";") {
                return 1;
            } else if (letter == "(") {
                return 28;
            } else if (letter == ")") {
                return 3;
            } else if (letter == "<") {
                return 71;
            } else if (letter == ">") {
                return 5;
            } else if (letter == "/") {
                return 8;
            } else if (letter == "|") {
                return 20;
            } else if (letter == "=") {
                return 62;
            } else if (letter == "+") {
                return 18;
            } else if (letter == "-") {
                return 37;
            } else if (letter == "_") {
                return 24;
            } else if (letter == "{") {
                return 49;
            } else if (letter == "}") {
                return 90;
            } else if (letter == "[") {
                return 6;
            } else if (letter == "]") {
                return 4;
            } else if (letter == "`") {
                return 72;
            } else if (letter == "~") {
                return 25;
            } else if (letter == "@") {
                return 73;
            } else if (letter == "#") {
                return 32;
            } else if (letter == "$") {
                return 70;
            } else if (letter == "%") {
                return 82;
            } else if (letter == "^") {
                return 88;
            } else if (letter == "&") {
                return 54;
            } else if (letter == "*") {
                return 23;
            } else if (letter == "\\") {
                return 84;
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Converts numbers to characters (in the form of a string)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberToLetter(int number) {
            // Lower case letters
            if (number == 44) {
                return "a";
            } else if (number == 87) {
                return "b";
            } else if (number == 12) {
                return "c";
            } else if (number == 13) {
                return "d";
            } else if (number == 89) {
                return "e";
            } else if (number == 59) {
                return "f";
            } else if (number == 83) {
                return "g";
            } else if (number == 34) {
                return "h";
            } else if (number == 63) {
                return "i";
            } else if (number == 55) {
                return "j";
            } else if (number == 58) {
                return "k";
            } else if (number == 78) {
                return "l";
            } else if (number == 17) {
                return "m";
            } else if (number == 61) {
                return "n";
            } else if (number == 94) {
                return "o";
            } else if (number == 68) {
                return "p";
            } else if (number == 2) {
                return "q";
            } else if (number == 81) {
                return "r";
            } else if (number == 46) {
                return "s";
            } else if (number == 30) {
                return "t";
            } else if (number == 29) {
                return "u";
            } else if (number == 16) {
                return "v";
            } else if (number == 36) {
                return "w";
            } else if (number == 56) {
                return "x";
            } else if (number == 11) {
                return "y";
            } else if (number == 21) {
                return "z";
            }

              // Upper Case letters
              else if (number == 39) {
                return "A";
            } else if (number == 41) {
                return "B";
            } else if (number == 77) {
                return "C";
            } else if (number == 14) {
                return "D";
            } else if (number == 67) {
                return "E";
            } else if (number == 48) {
                return "F";
            } else if (number == 92) {
                return "G";
            } else if (number == 15) {
                return "H";
            } else if (number == 91) {
                return "I";
            } else if (number == 9) {
                return "J";
            } else if (number == 93) {
                return "K";
            } else if (number == 64) {
                return "L";
            } else if (number == 80) {
                return "M";
            } else if (number == 75) {
                return "N";
            } else if (number == 22) {
                return "O";
            } else if (number == 53) {
                return "P";
            } else if (number == 26) {
                return "Q";
            } else if (number == 42) {
                return "R";
            } else if (number == 76) {
                return "S";
            } else if (number == 45) {
                return "T";
            } else if (number == 66) {
                return " ";
            } else if (number == 35) {
                return "V";
            } else if (number == 47) {
                return "W";
            } else if (number == 31) {
                return "X";
            } else if (number == 33) {
                return "Y";
            } else if (number == 7) {
                return "Z";
            }

              // Numbers
              else if (number == 19) {
                return "1";
            } else if (number == 10) {
                return "2";
            } else if (number == 65) {
                return "3";
            } else if (number == 51) {
                return "4";
            } else if (number == 60) {
                return "5";
            } else if (number == 79) {
                return "6";
            } else if (number == 85) {
                return "7";
            } else if (number == 74) {
                return "8";
            } else if (number == 38) {
                return "9";
            } else if (number == 27) {
                return "0";
            }

              // Other Characters
              else if (number == 52) {
                return "\"";
            } else if (number == 40) {
                return "'";
            } else if (number == 69) {
                return "!";
            } else if (number == 43) {
                return "?";
            } else if (number == 86) {
                return ".";
            } else if (number == 57) {
                return ",";
            } else if (number == 50) {
                return ":";
            } else if (number == 1) {
                return ";";
            } else if (number == 28) {
                return "(";
            } else if (number == 3) {
                return ")";
            } else if (number == 71) {
                return "<";
            } else if (number == 5) {
                return ">";
            } else if (number == 8) {
                return "/";
            } else if (number == 20) {
                return "|";
            } else if (number == 62) {
                return "=";
            } else if (number == 18) {
                return "+";
            } else if (number == 37) {
                return "-";
            } else if (number == 24) {
                return "_";
            } else if (number == 49) {
                return "{";
            } else if (number == 90) {
                return "}";
            } else if (number == 6) {
                return "[";
            } else if (number == 4) {
                return "]";
            } else if (number == 72) {
                return "`";
            } else if (number == 25) {
                return "~";
            } else if (number == 73) {
                return "@";
            } else if (number == 32) {
                return "#";
            } else if (number == 70) {
                return "$";
            } else if (number == 82) {
                return "%";
            } else if (number == 88) {
                return "^";
            } else if (number == 54) {
                return "&";
            } else if (number == 23) {
                return "*";
            } else if (number == 84) {
                return "\\";
            } else {
                return "U";
            }
        }
    }
}
