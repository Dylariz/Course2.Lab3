using System.Collections.Generic;
using System.Windows.Forms;

namespace Number4
{
    public static class ExtensionMethods
    {
        public static Dictionary<char, string> MorseCodeDictionary = new Dictionary<char, string>()
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." },
            { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." },
            { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
            { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." },
            { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" },
            { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
            { 'Y', "-.--" }, { 'Z', "--.." }, { ' ', " " }
        };

        public static void ToMorse(this RichTextBox inputTextBox, RichTextBox outputTextBox)
        {
            inputTextBox.TextChanged += delegate
            {
                string result = inputTextBox.Text.ToUpper();
                char[] message = result.ToCharArray();

                result = "";
                foreach (var t in message)
                {
                    result += MorseCodeDictionary.TryGetValue(t, out string letter) ? letter : "?";
                    if (t != ' ')
                    {
                        result += " ";
                    }
                }

                outputTextBox.Text = result;
            };
        }
    }
}