using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastTheListLibrary
{
    public class ListProcessor
    {
        public string ListPrefix { get; set; }
        public string ListSufix { get; set; }

        public string ItemPrefix { get; set; }
        public string ItemSufix { get; set; }

        public bool InNewLine { get; set; }

        public List<string> Items { get; set; } = new List<string>();

        StringBuilder _sb = new StringBuilder();
        private string ClibboarText{get { return Clipboard.GetText(); }
        }

        private string List()
        {
            string output = "";

            return output;
        }

        public string ClibboarText
        {
            get { return Clipboard.GetText(); }
        }
    }
}
