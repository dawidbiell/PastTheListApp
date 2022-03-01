using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastTheListLibrary
{
    public class ListProcessor:INotifyPropertyChanged
    {
        public string Separator { get; set; }
        public string ListPrefix { get; set; }
        public string ListSufix { get; set; }
        public string ItemPrefix { get; set; }
        public string ItemSufix { get; set; }
        public bool InNewLine { get; set; }
        
        public int ItemsCount
        {
            get { return this.GetItems().Length; }
        }
        public string Preview
        {
            get { return this.GetList(); }
        }


        private string ListNewLine()
        {
            return InNewLine ? Environment.NewLine : String.Empty; 
        }

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

            sb.Append(ListPrefix);
            sb.Append(ItemPrefix);

            sb.Append(String.Join(ItemSufix + Separator + ListNewLine() + ItemPrefix, items));

            sb.Append(ItemSufix);
            sb.Append(ListSufix);


            return sb.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
