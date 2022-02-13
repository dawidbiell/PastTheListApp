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
        public string Separator { get; set; }
        public string ListPrefix { get; set; }
        public string ListSufix { get; set; }

        public string ItemPrefix { get; set; }
        public string ItemSufix { get; set; }

        public bool InNewLine { get; set; }
        private string NewLine
        {
            get { return InNewLine ? Environment.NewLine : String.Empty; }
        }

        public int ItemsCount { get { return GetItems().Length; } }


        private string[] GetItems()
        {
            string[] items;
            string cbText;
            char[] cbDelimeters;

            cbText = Clipboard.GetText();
            cbDelimeters = new char[] { '\r', '\n', '\t' };
            items = cbText.Split(cbDelimeters, StringSplitOptions.RemoveEmptyEntries);

            return items;
        }

        public string GetList()
        {
            StringBuilder sb = new StringBuilder();
            string[] items = GetItems();
            //items.Where(x => !String.IsNullOrEmpty(x)).ToArray();

            sb.Append(ListPrefix);
            sb.Append(ItemPrefix);

            sb.Append(String.Join(ItemSufix + Separator+ NewLine + ItemPrefix, items));

            sb.Append(ItemSufix);
            sb.Append(ListSufix);


            return sb.ToString();
        }


    }
}
