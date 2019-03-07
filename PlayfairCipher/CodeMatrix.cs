using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairCipher
{
    class CodeMatrix
    {
        private readonly char[,] matrix = new char[5, 5];
        private readonly char[] characters = new char[25];
        private readonly string keyPhrase;
        private readonly char[] letters = {'A','B','C','D','E','F','G','H','I','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public CodeMatrix(string keyPhrase)
        {
            this.keyPhrase = keyPhrase;
            CreateMatrix(keyPhrase);
        }

        public string EncodeMessage(string originalMessage)
        {
            // CreateMatrix(keyPhrase);    

            originalMessage = originalMessage.ToUpper().Replace('J', 'I');
           // originalMessage = originalMessage.Replace('J', 'I');
            StringBuilder sb = new StringBuilder(originalMessage);
            StringBuilder cb = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ' ')
                {
                    cb.Append(sb[i]);
                }
                else
                {
                    char z = applyMatrix(sb[i]);
                    cb.Append(z);
                }
            }
            return cb.ToString();
        }

        private char applyMatrix(char v)
        {
            char codeLetter = ' ';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((matrix[i, j]).CompareTo(v) == 0)
                    {
                        codeLetter = matrix[j, i];
                    }
                }
            }
            return codeLetter;
        }


        private void CreateMatrix(string keyPhrase)
        {
            // List<char> characters = new List<char>;
           // char letter = 'A';
            int matrixIndex = 0;

            char[] trimmedPassPhrase = TrimPassPhrase(keyPhrase).ToCharArray();
                        for (matrixIndex = 0; matrixIndex < trimmedPassPhrase.Length; matrixIndex++)
            {
                characters[matrixIndex] = trimmedPassPhrase[matrixIndex];
            }

            // populate characters with characters excepting 
            // letters already used in the pass phrase
            // int characterLimit = matrixIndex + 25;
            for (int i = 0; i < 25; i++)
            {
                if (!trimmedPassPhrase.Contains(letters[i]))
                {
                    characters[matrixIndex] = letters[i];
                    matrixIndex++;
                }                
            }
           
            //create a code matrix
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = characters[counter];
                    counter++;
                }
            }
        }
        //Trim repeating characters from pass phrase allowing spaces and punctuation
        //Apply using LINQ command
        public string TrimPassPhrase(string passPhrase)
        {
            return new string(passPhrase.ToUpper().ToCharArray().Distinct().ToArray());
        }

        //Alternate method that trims spaces as well 
        public string RemoveSpaces(string passPhrase)
        {
            return new string(passPhrase.ToCharArray().Except(" ").ToArray());
        }
        
        public override string ToString()
        {
            //print out code matrix for manual use later and for testing purposes
            StringBuilder sb = new StringBuilder();
            sb.Append("     ");
            
            for (int i = 0; i < 5; i++)
            {
                sb.Append($"{i}  ");
            }

            for (int i = 0; i < 5; i++)
            {
                sb.Append($"\n {i}   ");
                for (int j = 0; j < 5; j++)
                {
                    sb.Append(matrix[i, j] + "  ");
                }
            }
            return sb.ToString();
        }
    }
}

