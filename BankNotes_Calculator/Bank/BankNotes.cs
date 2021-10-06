using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNotes_Calculator.Bank
{
    class BankNotes
    {

        private string devisa;
        public string Devisa { get => devisa; }

        private int[] noteList;
        public int[] NoteList { get => noteList; }

        public BankNotes(string devisa)
        {
            this.devisa = devisa;
            setNoteList(devisa);
        }

        public void setNoteList(String devisa)
        {
            this.devisa = devisa;
            int[] HUF = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };
            int[] CZK = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000 };

            switch(devisa)
            {
                case "HUF":
                    Array.Sort(HUF);
                    Array.Reverse(HUF);
                    noteList = HUF;
                    break;
                case "CZK":
                    Array.Sort(CZK);
                    Array.Reverse(CZK);
                    noteList = CZK;
                    break;
                default:
                    Array.Sort(HUF);
                    Array.Reverse(HUF);
                    noteList = HUF;
                    break;

            }
        }

    }
}
