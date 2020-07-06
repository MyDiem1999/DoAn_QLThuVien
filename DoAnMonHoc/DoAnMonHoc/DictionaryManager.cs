using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc
{
    public class DictionaryManager
    {
        //#region properties
        //private DictionaryItem items;

        //public DictionaryItem Items
        //{
        //    get { return items; }
        //    set { items = value; }
        //}
        //#endregion

        //#region methods
        //// Load DL len ComboBox
        //public void loadDatatoComboBox(ComboBox combo)
        //{

        //}

        //// Luu DL xuong .XML
        //public void SerializeToXML()
        //{
        //}

        //// Lay DL tu .XML len
        //public object DeserializeFromXML(object date, string path)
        //{
        //    return 0;
        //}
        //#endregion

        public DictionaryItem[] lstWord = new DictionaryItem[1];
        private string[] fileName = new string[1];

        public DictionaryManager()
        {
            fileName[0] = "data.txt";

            for (int i = 0; i < 1; i++)
            {

                lstWord[i] = new DictionaryItem(fileName[i]);
            }
  
        }

        public DictionaryItem this[int index]
        {
            get { return (DictionaryItem)lstWord[index]; }
        }

        #region methods
        public void ReadFromData()
        {
            foreach (DictionaryItem items in lstWord)
            {
                items.ReadFile();
            }
        }
        #endregion




        public int hashkey(string key)
        {
            int i = 0;
            switch (key[0])
            {
                case 'a': i = 0;
                    break;
                case 'b': i = 1;
                    break;
                case 'c': i = 2;
                    break;
            }

            return i;
        }

    }
}
