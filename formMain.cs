using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Anagram
{
    public partial class formMain : Form
    {
        Random _rnd = new Random();
        //dictionary loaded into memory
        List<string> _dictionary = new List<string>();
        List<string> _matchedWords = new List<string>();

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
            var timeStart = DateTime.Now;
            var letterList = new List<char>();
            _matchedWords.Clear();
            foreach (var letter in tbChars.Text.Split(',')) 
            {
                letterList.Add(char.Parse(letter));
            }
            foreach (var letter in letterList.ToArray())
            {
                var tempList = letterList;
                tempList.Remove(letter);
                var charLeft = "";
                foreach (var x in tempList)
                {
                    charLeft += x;
                }
                var wordsBeginningList = new List<string>();
                foreach (var word in _dictionary)
                {
                    if (word.Length<=letterList.Count() && word.StartsWith(letter.ToString()))
                    {
                        wordsBeginningList.Add(word);
                    }
                }
                filterWord(wordsBeginningList, charLeft, letter.ToString());

            }
            lboxWords.DataSource = null;
            lboxWords.DataSource = _matchedWords;
            var timeEnd = DateTime.Now;
            var timeTaken = timeEnd - timeStart;
            lblTimeTaken.Text = $"Time taken: {timeTaken.TotalMilliseconds}";
        }

        public void filterWord(List<string> words, string charLeft, string prefix)
        {
            if (charLeft.Length == 0)
            {
                _matchedWords.Add(prefix);
            }
            if (words.Count == 0)
            {
                return;
            }
            else
            {
                var charToAdd = charLeft.ToCharArray()[0];
                prefix += charToAdd;
                foreach (var word in words.ToArray())
                {
                    if (word == prefix)
                    {
                        _matchedWords.Add(word);
                        words.Remove(word);
                    }
                    else if (word.StartsWith(prefix) == false)
                    {
                        words.Remove(word);
                    }
                }
                charLeft = charLeft.Substring(1);
                filterWord(words, charLeft, prefix);
            }
        }
    }
}
        