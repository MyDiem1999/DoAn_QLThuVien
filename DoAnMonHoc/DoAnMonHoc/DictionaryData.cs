using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc
{
    public class DictionaryData
    {
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string meaning;

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }
        private string pronounce;

        public string Pronounce
        {
            get { return pronounce; }
            set { pronounce = value; }
        }
        private string wordType;

        public string WordType
        {
            get { return wordType; }
            set { wordType = value; }
        }

        public DictionaryData(string key)
        {
            this.key = key;
        }

        public DictionaryData(string k, string m, string pro, string wt)
        {
            this.key = k;
            this.meaning = m;
            this.pronounce = pro;
            this.wordType = wt;
        }

        //in tu ra
        public override string ToString()
        {
            string rs = "";
            rs = wordType + "" + pronounce + "" + meaning;
            return rs;
        }

    }
}
