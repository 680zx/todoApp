using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoApp.Common.Interfaces;

namespace todoApp.Common
{
    public class TextFormatter : ITextFormatter
    {
        private int _maxRowLength;

        public TextFormatter(int maxRowLength)
        {
            _maxRowLength = maxRowLength;
        }

        public string Format(string text)
        {
            string[] words = text.Split(" ");
            var formattedString = new StringBuilder();
            var currentStringLine = new StringBuilder();

            // used for adding last current string line to the formatted string
            // before exiting the loop
            var wordCounter = 0;

            foreach (var word in words)
            {
                wordCounter++;

                if (currentStringLine.Length + word.Length > _maxRowLength)
                {
                    // remove last gap character because it's useless
                    currentStringLine.Remove(currentStringLine.Length - 1, 1);
                    formattedString.Append(currentStringLine);
                    formattedString.Append("\n");
                    currentStringLine.Clear();
                }
                
                currentStringLine.Append(word);
                currentStringLine.Append(" ");

                if (wordCounter == words.Length)
                {
                    currentStringLine.Remove(currentStringLine.Length - 1, 1);
                    formattedString.Append(currentStringLine);
                }
            }

            return formattedString.ToString();
        }
    }
}
