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

using PastTheListLibrary.ClipboardMonitor;
using System.Diagnostics;

namespace PastTheList
{
    public partial class Main : Form
    {
        private ListProcessor _list = new ListProcessor();

        public Main()
        {
            InitializeComponent();
            RegisterClipboardViewer();
            BindControls();
        }

        private void BindControls()
        {
            separator_tbx.DataBindings.Add("Text", _list, nameof(_list.Separator), true, DataSourceUpdateMode.OnPropertyChanged);
            listPrefix_tbx.DataBindings.Add("Text", _list, nameof(_list.ListPrefix), true, DataSourceUpdateMode.OnPropertyChanged);
            itemPrefix_tbx.DataBindings.Add("Text", _list, nameof(_list.ItemPrefix), true, DataSourceUpdateMode.OnPropertyChanged);
            itemSufix_tbx.DataBindings.Add("Text", _list, nameof(_list.ItemSufix), true, DataSourceUpdateMode.OnPropertyChanged);
            listSufix_tbx.DataBindings.Add("Text", _list, nameof(_list.ListSufix), true, DataSourceUpdateMode.OnPropertyChanged);

            inNewLine_chk.DataBindings.Add("Checked", _list, nameof(_list.InNewLine), true, DataSourceUpdateMode.OnPropertyChanged);
            uniqueItems_chk.DataBindings.Add("Checked", _list, nameof(_list.UniqueItems), true, DataSourceUpdateMode.OnPropertyChanged);
            splitBySeparator_chk.DataBindings.Add("Checked", _list, nameof(_list.SplitByseparator), true, DataSourceUpdateMode.OnPropertyChanged);

            itemsCount_lbl.DataBindings.Add("Text", _list, nameof(_list.ItemsCount), true, DataSourceUpdateMode.OnPropertyChanged);
            uniqueItemsCount_lbl.DataBindings.Add("Text", _list, nameof(_list.UniqueItemsCount), true, DataSourceUpdateMode.OnPropertyChanged);


            preview.DataBindings.Add("Text", _list, nameof(_list.Preview), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region Clipboard Monitor

        /// <summary>
        /// https://www.radsoftware.com.au/articles/clipboardmonitor.aspx/
        /// </summary>

        IntPtr _ClipboardViewerNext;

		private void RegisterClipboardViewer()
        {
            _ClipboardViewerNext = User32.SetClipboardViewer(this.Handle);
        }

        private void UnregisterClipboardViewer()
        {
            User32.ChangeClipboardChain(this.Handle, _ClipboardViewerNext);
        }

        protected override void WndProc(ref Message m)
        {
            switch ((Msgs)m.Msg)
            {
                   
                case Msgs.WM_DRAWCLIPBOARD:

                    Debug.WriteLine("WindowProc DRAWCLIPBOARD: " + m.Msg, "WndProc");

                    GetClipboardData();
                    User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    break;

                case Msgs.WM_CHANGECBCHAIN:
                    Debug.WriteLine("WM_CHANGECBCHAIN: lParam: " + m.LParam, "WndProc");

                    if (m.WParam == _ClipboardViewerNext)
                        _ClipboardViewerNext = m.LParam;
                    else
                        User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }

            
        }

        private void GetClipboardData()
        {
            preview.Text = _list.Preview;
        }


        #endregion


    }
}
