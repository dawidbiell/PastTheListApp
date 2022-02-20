using PastTheListLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastTheList
{
    public partial class Main : Form
    {
        private ListProcessor _list = new ListProcessor();

        public Main()
        {
            InitializeComponent();

            BindControls();
            
        }

        private void BindControls()
        {
            separator_tbx.DataBindings.Add("Text", _list, nameof(_list.Separator), true, DataSourceUpdateMode.OnPropertyChanged);
            listPrefix_tbx.DataBindings.Add("Text", _list, nameof(_list.ListPrefix), true, DataSourceUpdateMode.OnPropertyChanged);
            itemPrefix_tbx.DataBindings.Add("Text", _list, nameof(_list.ItemPrefix), true, DataSourceUpdateMode.OnPropertyChanged);
            itemSufix_tbx.DataBindings.Add("Text", _list, nameof(_list.ItemSufix), true, DataSourceUpdateMode.OnPropertyChanged);
            listSufix_tbx.DataBindings.Add("Text", _list, nameof(_list.ListSufix), true, DataSourceUpdateMode.OnPropertyChanged);
            inNewLine.DataBindings.Add("Checked", _list, nameof(_list.InNewLine), true, DataSourceUpdateMode.OnPropertyChanged);



            preview.DataBindings.Add("Text", _list, nameof(_list.Preview), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        
    }
}
