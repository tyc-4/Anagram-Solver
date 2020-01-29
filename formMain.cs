using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Anagram
{
    public partial class formMain : Form
    {
        Random _rnd = new Random();
        //dictionary loaded into memory
        List<string> _dictionary = new List<string>();
        //list of characters
        string charString;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //randomly generate 10 characters and display into tbChars
            var generatedLetters = "";
            for (int i = 0; i < 10; i++)
            {
                var rndChar = (char)_rnd.Next('a', 'z');
                generatedLetters += $",{rndChar}";
            }
            tbChars.Text = generatedLetters.TrimStart(',');
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //load all words into dictionary
            var filePath = @"C:\Visual Studio Projects\Anagram\words_alpha.txt";
            StreamReader fileRead = new StreamReader(filePath);
            while (!fileRead.EndOfStream)
            {
                _dictionary.Add(fileRead.ReadLine());
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            charString = "";
            var charCount = 0;
            var _dictionaryF = new List<string>();
            var charList = new List<char>();
            //add the characters in textbox into list of characters
            foreach (var letter in tbChars.Text.Split(','))
            {
                charString += letter;
                charList.Add(letter[0]);
                charCount++;
            }

            //filtering down dictionary to not kill computer
            foreach (var word in _dictionary)
            {
                if (word.Length<=charCount && charList.Contains(word[0]))
                {
                    _dictionaryF.Add(word);
                }
            }

            Console.WriteLine(charString);

            var results = new List<string>();

            findWords(charString, "", results);

            Console.WriteLine("finished recursion");

            var validWords = new List<string>();

            foreach (var anagram in results)
            {
                if (_dictionaryF.Contains(anagram) && validWords.Contains(anagram) == false)
                {
                    validWords.Add(anagram);
                }
            }

            Console.WriteLine("comparing done");

            lboxWords.DataSource = null;
            lboxWords.DataSource = validWords;
        }

        private void findWords(string charLeft, string prefix, IList<string> result)
        {
            if (charLeft.Length == 0)
            {
                result.Add(prefix);
                return;
            }

            for (int i = 0; i < charLeft.Length; i++)
            {
                //setting first character as prefix
                var tempPrefix = charLeft[i].ToString();
                //making string of the rest of the letters
                var tempCharLeft = charLeft.Substring(0, i) + charLeft.Substring(i + 1);
                //new list to grab all anagram
                var tempResult = new List<string>();
                //recursion to iterate through all possible prefix
                findWords(tempCharLeft, tempPrefix, tempResult);
                foreach (var anagram in tempResult)
                {
                    result.Add($"{prefix}{anagram}");
                    Console.WriteLine(prefix + anagram);
                }
            }
        }
    }
}
