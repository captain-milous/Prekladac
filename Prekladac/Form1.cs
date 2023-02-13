using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prekladac
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> englishCzechDictionary = ImportDictionaryFrom("englishCzechDictionary.json");

        public Form1()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string word = wordTextBox.Text.ToLower();
            if (englishRadioButton.Checked)
            {
                if (englishCzechDictionary.ContainsKey(word))
                {
                    translationLabel.Text = englishCzechDictionary[word];
                }
                else
                {
                    translationLabel.Text = "The word is not present in the dictionary."
                        + "\n(Or you have selected the wrong language)";
                }
            }
            else if (czechRadioButton.Checked)
            {
                foreach (KeyValuePair<string, string> entry in englishCzechDictionary)
                {
                    if (entry.Value == word)
                    {
                        translationLabel.Text = entry.Key;
                        return;
                    }
                }
                translationLabel.Text = "The word is not present in the dictionary."
                    + "\n(Or you have selected the wrong language)";
            }
            else
            {
                translationLabel.Text = "Please select a language to translate from.";
            }
        }

        private void addTranstationButton_Click(object sender, EventArgs e)
        {
            string englishWord = englishWordTextBox.Text.ToLower();
            string czechWord = czechWordTextBox.Text.ToLower();
            if(englishWord != "" || czechWord != "")
            {
                englishCzechDictionary.Add(englishWord, czechWord);
                SaveDictionary(englishCzechDictionary);
            } 
            else
            {
                errorLabel.Text = "One of the translated words is not filled in.";
            }
        }

        public static void SaveDictionary(Dictionary<string, string> dic)
        {
            string dictionaryJson = JsonConvert.SerializeObject(dic);
            File.WriteAllText("englishCzechDictionary.json", dictionaryJson);
            MessageBox.Show("The dictionary has been saved to the file englishCzechDictionary.json.");
        }

        public static Dictionary<string, string> ImportDictionaryFrom(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            return dictionary;
        }
    }
}
