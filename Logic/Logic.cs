using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Logic
{
    public class Logic
    {
        public bool useAPI = false;
        public enum Register
        {
            UppCase,
            LowCase,
            EachWordIsCapitalized
        }

        string[] pathes =
        {
            @"..\..\..\..\Logic\Text Files\1.txt",
            @"..\..\..\..\Logic\Text Files\2.txt",
            @"..\..\..\..\Logic\Text files\3.txt",
            @"..\..\..\..\Logic\Text Files\\4.txt"
        };
        string[][] fileStrings = new string[4][];

        public Logic()
        {
        }

        public string[] GetPathes ()
        {
            return pathes;
        }

        public string[][] GetFileStrings()
        {
            if (fileStrings.Contains(null)) ReadFiles();

            Debug.WriteLine("Returned fileStrings");
            return fileStrings;
        }

        void ReadFiles()
        {
            for (int i = 0; i < pathes.Length; i++)
            {
                Debug.WriteLine($"ReadFiles running for {i} times");
                string[] allLines = File.ReadAllLines(pathes[i]);
                fileStrings[i] = (string[])allLines.Where(
                    x => !string.IsNullOrWhiteSpace(x)).ToArray();
            }
        }

        public string GenerateText(int numOfSentence, Register register)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            
            sb.Append('\t');

            if (useAPI)
            {
                sb.Append(getAPIText(numOfSentence));
            }
            else
            {
                for (int i = 0; i < numOfSentence; i++)
                {
                    foreach (string[] s in fileStrings)
                    {
                        sb.Append(s[random.NextInt64(0, s.Length)].ToLower());
                        sb.Append(' ');
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(". ");
                }
            }            

            string result = sb.ToString();
            result = normalizeText(result);

            if (register.Equals(Register.UppCase))
            {
                return result.ToUpper();
            }

            if (register.Equals(Register.LowCase))
            {
                return result;
            }

            if (register.Equals(Register.EachWordIsCapitalized))
            {
                return makeEachWordIsCapitalized(result);
            }

            return "";
        }

        string makeEachWordIsCapitalized (string text)
        {
            string result = Regex.Replace(
                            text,
                            @"(^\w)|(\.\s\w)|(\.\w)|(\t\s\w)|(\t\w)",
                            m => m.Value.ToUpper());

            return result;
        }

        string normalizeText(string text)
        {
            string result;
            Regex regex = new Regex(@"((\s?[.]))");

            text = text.ToLower();
            result = regex.Replace(text, ".");

            regex = new Regex(@"(\t\s\w)");
            result = regex.Replace(result, "\t");

            regex = new Regex(@"\.");

            Random random = new Random();
            result = regex.Replace(result, x => random.NextInt64(1, 11) <= 3? ".\n\t": ".");

            return result;
        }

        string getAPIText(int len)
        {
            string line;
            using (WebClient wc = new WebClient())
            {
                line = wc.DownloadString($"https://fish-text.ru/get?format=html&number={len}");
            }
            Match match = Regex.Match(line,
                            "<p>(.*?)</p>");

            string text = match.Groups[1].Value;
            return text;


        }

        public void Save(string[][] strings)
        {
            string lines;

            //File 1
            lines = "";
            foreach (string s in strings[0])
            {
                lines += $"{s}\n";
            }
            File.WriteAllText(pathes[0], lines);

            //File 2
            lines = "";
            foreach (string s in strings[1])
            {
                lines += $"{s}\n";
            }
            File.WriteAllText(pathes[1], lines);

            //File 3
            lines = "";
            foreach (string s in strings[2])
            {
                lines += $"{s}\n";
            }
            File.WriteAllText(pathes[2], lines);

            //File 4
            lines = "";
            foreach (string s in strings[3])
            {
                lines += $"{s}\n";
            }
            File.WriteAllText(pathes[3], lines);
        }
    }
}
