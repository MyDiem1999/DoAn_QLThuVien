using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc
{
    public class DictionaryItem
    {
        public Hashtable lst = new Hashtable();

        public string fileName = "";

        public DictionaryItem()
        {

        }

        public DictionaryItem(string filename)
        {
            fileName = filename;
        }

        public DictionaryData this[int cs]
        {
            get { return (DictionaryData)lst[cs]; }
        }
                   
        //thêm từ có key và value
        public void addWord(string key, DictionaryData value)
        {
            lst.Add(key, value);
        }

        //thêm từ với tất cả tham số
        public void addWord(string key, string wt, string pro, string m)
        {
            DictionaryData data = new DictionaryData(key, wt, pro, m);
            lst.Add(key, data);
        }

        #region methods
        public void ReadFile()
        {
            string text;
            string[] tam;
            FileStream myFile;

            if (File.Exists(fileName))
            {
                myFile = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(myFile);

                for (; (text = sr.ReadLine()) != null; )
                {
                    tam = text.Split('-');
                    addWord(tam[0], tam[1], tam[2], tam[3]);
                }
                sr.Close();
                myFile.Close();
            }
            else
                myFile = new FileStream(fileName, FileMode.Create);
        }
        #endregion

        public void inkey(ref string[] s)
        {
            int i = 0;
            s = new string[lst.Keys.Count];
            ICollection c = lst.Keys;

            foreach (string item in c)
            {
                s[i] = item;
                i++;
            }
        }

    }
}
