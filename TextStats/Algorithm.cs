using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CP
{
    // Assumptions; 
    //  Numeric and special characters are treated like space.
    //      "20th" is treated as the word "th".
    //      'I co-wrote' is treated as 3 words: 'I', 'co' and 'wrote'
    //  Words are to be treated as the uppercase version.
    //      'AMBIENT', 'Ambient' and 'ambient' are treated as "AMBIENT".
    //  Lower and upper case characters are not differentiated.
    //      'A' and 'a' are both 'A'.
    //      Special characters are ignored. Not interested in frequency of '-'.

    public class Algorithm
    {
       private String fileName;
        // To implement ..
        public Algorithm(String fileName)
        {
            this.fileName = fileName;
        }

        public void GetCharFrequency()
        {
            // 1.
            // Array to store frequencies.
            #region MyRegion
            char[] capital = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J','K', 'L', 'M', 'N',
                       'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};


            // 2.
            // Read entire text file.
            String line = ReadAllTextAndConvertToUpperCase(fileName);

            int[] count = new int[26]; //Max 26 aplhabets


            //Convert all characters to UpperCase
            char[] characters = line.ToCharArray();

            Console.WriteLine(characters);

            #endregion
            
            // 3.
            // Iterate over each character.
            for (int i = 0; i < characters.Length; i++)
                {
                    for (int j = 0; j < capital.Length; j++)
                    {
                        if (characters[i] == capital[j])
                        {
                            count[j]++;
                            break;
                        }
                    }
                }


            // 4.
            // Write all letters found.
            Console.WriteLine("Item \t Frequency");
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("{0} \t {1}", capital[i], count[i]);
            }

            }
       

        public void GetWordFrequency()
        {

            // 1.
            // Dictionary to map words and frequency.
            var wordFreq = new Dictionary<string, int>();

            // 2.
            // Read entire text file.
            String line = ReadAllTextAndConvertToUpperCase(fileName);

            //3.
            //Replace/remove all special chars and numeric
            var lines = Regex.Replace(line, @"[^A-Z ]+", "");

            //4.
            //Splits the line by space ' '
            var words = lines.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            // 5.
            // Iterate and compare over each words.
            foreach (var word in words)
            {
                if (wordFreq.ContainsKey(word))
                {
                    wordFreq[word]++;
                }
                else
                {
                    wordFreq.Add(word, 1);
                }

            }


            Console.WriteLine("\nItem \t Frequency");

            // 6.
            // Write all words in order.
            foreach (var str in wordFreq.OrderBy(i => i.Key))
            {
                Console.WriteLine("{0} \t {1}", str.Key, str.Value);
                
            }
           
        }

       
        public string ReadAllTextAndConvertToUpperCase(string fileName)
        {
            String text = File.ReadAllText(fileName);
            return text.ToUpper();
        }
    }
}
