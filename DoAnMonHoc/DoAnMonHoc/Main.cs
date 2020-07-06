using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DictionaryManager dic = new DictionaryManager();
            dic.ReadFromData();
            putAllWordsInListBox(dic);
            
        }

        private void putAllWordsInListBox(DictionaryManager dic)
        {
            string[] s = null;
            for (int i = 0; i < 1; i++)
            {
                dic[i].inkey(ref s);

                if (s != null)
                {
                    foreach (string item in s)
                    {
                        lstTuVung.Items.Add(item);
                    }
                }
            }
        }
    }
}
