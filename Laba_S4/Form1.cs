using Microsoft.VisualBasic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Laba_S4
{
    public partial class Form1 : Form
    {
        string RegisterOfText = string.Empty;
        int LengthOfText;
        bool Random = false;
        const int Height = 406;
        Logic.Logic logic;
        int totalChars = 0;
        int totalWords = 0;
        int totalUniqueWords = 0;
        Dictionary<string, int> threeMax;

        public Form1()
        {
            InitializeComponent();
            logic = new();
            RegisterOfText = SetRegisterOfTextComboBox.Text;
            LengthOfText = Convert.ToInt32(SetLengthOfTextNumeric.Value);
            word1Panel.Height = 0;
            word2Panel.Height = 0;
            word3Panel.Height = 0;
        }

        void SetRegisterOfTextComboBox_TextChanged(
            object sender, EventArgs e)
        {
            Debug.WriteLine("SetRegisterOfTextComboBox_TextChanged was started");
            RegisterOfText = SetRegisterOfTextComboBox.Text;
        }

        void SetRegisterOfTextComboBox_DropDownClosed(
            object sender, EventArgs e)
        {
            RandomRegisterCheckBox.Checked = false;
        }

        void SetLengthOfTextNumeric_ValueChanged(
            object sender, EventArgs e)
        {
            Debug.WriteLine("SetLengthOfTextNumeric_ValueChanged is started");
            LengthOfText = Convert.ToInt32(SetLengthOfTextNumeric.Value);
        }

        void RandomRegisterCheckBox_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Debug.WriteLine("RandomRegisterCheckBox_CheckedChanged is started");

            switch (RandomRegisterCheckBox.Checked)
            {
                case false:
                    Debug.WriteLine($"\t{RandomRegisterCheckBox.Checked}");
                    RandomRegisterCheckBox.Checked = false;
                    break;

                case true:
                    int randomIndex = (int)random.NextInt64(0, SetRegisterOfTextComboBox.Items.Count);
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    SetRegisterOfTextComboBox.Text = (string)SetRegisterOfTextComboBox.Items[
                        index: randomIndex];
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    Debug.WriteLine($"\t{RandomRegisterCheckBox.Checked}");
                    RandomRegisterCheckBox.Checked = true;
                    break;
            }

        }
        Dictionary<string, int> getThreeMax(Dictionary<string, int> kvp)
        {
            var max1 = new KeyValuePair<string, int>("", 0);
            var max2 = new KeyValuePair<string, int>("", 0);
            var max3 = new KeyValuePair<string, int>("", 0);

            foreach (string key in kvp.Keys)
            {
                if (kvp[key] > max3.Value)
                {
                    if (kvp[key] > max2.Value)
                    {
                        if (kvp[key] > max1.Value)
                        {
                            max3 = max2;
                            max2 = max1;
                            max1 = new KeyValuePair<string, int>(key, kvp[key]);
                        }
                        else
                        {
                            max3 = max2;
                            max2 = new KeyValuePair<string, int>(key, kvp[key]);
                        }
                    }
                    else
                    {
                        max3 = new KeyValuePair<string, int>(key, kvp[key]);
                    }
                }
            }
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                [max1.Key] = max1.Value,
                [max2.Key] = max2.Value,
                [max3.Key] = max3.Value
            };

            return result;
        }

        void updateLabels(object sender, EventArgs e)
        {
            updateProps();

            Regex regex = new Regex(@":\s*\w*\d*");

            NumOfCharsInTextLabel.Text = regex.Replace(
                    NumOfCharsInTextLabel.Text, $": {totalChars}");
            NumOfWordsInTextLabel.Text = regex.Replace(
                    NumOfWordsInTextLabel.Text, $": {totalWords}");
            NumOfUnicWordsInTextLabel.Text = regex.Replace(
                    NumOfUnicWordsInTextLabel.Text, $": {totalUniqueWords}");

            regex = new Regex(@"\|(.*?):(.*?)\|");
            MatchCollection collection = regex.Matches(threeMaxToString());

            try
            {
                int c1 = Convert.ToInt32(collection[0].Groups[2].Value);
                int c2 = Convert.ToInt32(collection[1].Groups[2].Value);
                int c3 = Convert.ToInt32(collection[2].Groups[2].Value);

                word1Label.Text = $"{collection[0].Groups[1].Value}\n{c1}";
                word2Label.Text = $"{collection[1].Groups[1].Value}\n{c2}";
                word3Label.Text = $"{collection[2].Groups[1].Value}\n{c3}";

                double d = (2.0 * Height / (c1 + c2 + c3));
                Debug.WriteLine(d);

                word1Panel.Height = (int)(d * c1);
                word2Panel.Height = (int)(d * c2);
                word3Panel.Height = (int)(d * c3);
            }
            catch { }

        }

        string threeMaxToString()
        {
            string s = "";
            foreach (string key in threeMax.Keys)
            {
                s += $"|{key}:{threeMax[key]}|";
            }
            return s;
        }

        void updateProps()
        {
            string text = GeneratedTextTextBox.Text;
            string[] words = text.Split(new string[] { ", ", ". ", " ", "\n", "\t" },
                                StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> uniqueWordsKVP = countUniqueWords(words);

            totalChars = text.Length;
            totalWords = words.Length;
            totalUniqueWords = uniqueWordsKVP.Count();
            threeMax = getThreeMax(uniqueWordsKVP);
        }

        Dictionary<string, int> countUniqueWords(string[] words)
        {
            Debug.WriteLine("countUniqueWords");

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 1;
                }
                else
                {
                    result[word]++;
                }
            }

            return result;
        }

        void GenerateTextButton_Click(object sender, EventArgs e)
        {
            bool fileStringsIsNull = logic.GetFileStrings() == null;
            if (fileStringsIsNull)
            {
                MessageBox.Show("Словарь данных пуст! Пожалуйста добавьте данные");
            }

            else
            {
                string text;
                switch (SetRegisterOfTextComboBox.Text)
                {
                    case "Заглавный":
                        text = logic.GenerateText(
                            LengthOfText,
                            Logic.Logic.Register.UppCase);
                        break;

                    case "Строчный":
                        text = logic.GenerateText(
                            LengthOfText,
                            Logic.Logic.Register.LowCase);
                        break;

                    case "Каждое слово с заглавной буквы":
                        text = logic.GenerateText(
                            LengthOfText,
                            Logic.Logic.Register.EachWordIsCapitalized);
                        break;

                    default:
                        text = "";
                        break;
                }
                GeneratedTextTextBox.Text = text;
            }
        }

        void useChatGPTCheckBox_Click(object sender, EventArgs e)
        {
            logic.useAPI = useChatGPTCheckBox.Checked;
        }

        private void WathDataButton_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Form2())).Start();
        }
    }
}