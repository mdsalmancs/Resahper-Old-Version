using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Metro.Logical
{
    class SuggestionProvider
    {
        private static List<string> keywordList;
        private static ListBox suggestionBox;

        public static void InitKeywordList(ListBox box)
        {
            suggestionBox = box;
            SuggestionList sg = new SuggestionList();
            keywordList = sg.GetSuggestionList();

        }

        public static void GetSuggestion(string key)
        {
            if (keywordList.Any(str => str.Contains(key)))
            {
                foreach (string s in keywordList)
                {
                    if (s.StartsWith(key))
                    {
                        if (!suggestionBox.Items.Contains(s))
                        {
                            suggestionBox.Items.Add(s);
                        }
                    }
                }
            }

            else
            {
                suggestionBox.Items.Clear();
            }
        }
    }

}
