using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Anagram
{
    public partial class formV2 : Form
    {
        public formV2()
        {
            InitializeComponent();
        }

        Random _rnd = new Random();
        Dictionary<string, int> _dictionary = new Dictionary<string, int>();
        Dictionary<char, int> _letterdictionary = new Dictionary<char, int>();

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //randomly generate 10 characters and display into tbChars
            var generatedLetters = "";
            for (int i = 0; i < 10; i++)
            {
                var rndChar = (char)_rnd.Next('A', 'Z');
                generatedLetters += rndChar;
            }
            tbChars.Text = generatedLetters;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var letters = tbChars.Text.ToCharArray();

            var number = 1;

            foreach (var letter in letters)
            {
                _letterdictionary.TryGetValue(letter, out int prime);
                number = number * prime;
            }

            var foundwords = new List<string>();

            foreach (var word in _dictionary)
            {
                if (number % word.Value == 0)
                {
                    foundwords.Add(word.Key);
                }
            }

            lboxWords.DataSource = foundwords;
        }

        private void formV2_Load(object sender, EventArgs e)
        {
            //assign prime number to all letters
            _letterdictionary.Add('A', 2);
            _letterdictionary.Add('B', 3);
            _letterdictionary.Add('C', 5);
            _letterdictionary.Add('D', 7);
            _letterdictionary.Add('E', 11);
            _letterdictionary.Add('F', 13);
            _letterdictionary.Add('G', 17);
            _letterdictionary.Add('H', 19);
            _letterdictionary.Add('I', 23);
            _letterdictionary.Add('J', 29);
            _letterdictionary.Add('K', 31);
            _letterdictionary.Add('L', 37);
            _letterdictionary.Add('M', 41);
            _letterdictionary.Add('N', 43);
            _letterdictionary.Add('O', 47);
            _letterdictionary.Add('P', 53);
            _letterdictionary.Add('Q', 59);
            _letterdictionary.Add('R', 61);
            _letterdictionary.Add('S', 73);
            _letterdictionary.Add('T', 79);
            _letterdictionary.Add('U', 83);
            _letterdictionary.Add('V', 89);
            _letterdictionary.Add('W', 97);
            _letterdictionary.Add('X', 101);
            _letterdictionary.Add('Y', 103);
            _letterdictionary.Add('Z', 107);
            //load all words into dictionary
            var filePath = @"C:\Visual Studio Projects\Anagram\words_alpha.txt";
            StreamReader fileRead = new StreamReader(filePath);
            while (!fileRead.EndOfStream)
            {
                var word = fileRead.ReadLine();
                var wordC = word.ToCharArray();
                var number = 1;

                foreach (var letter in wordC)
                {
                    _letterdictionary.TryGetValue(letter, out int prime);
                    number = number * prime;
                }

                _dictionary.Add(word, number);
            }
        }
    }
}
