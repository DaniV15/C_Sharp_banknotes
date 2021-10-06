using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNotes_Calculator.Bank
{
    class Banker
    {

        private int[] notes;
        public int[] Notes{ set => notes = value; }
        private int amount;
        public int Amount { set => amount = value; }
        
        public static Banker GetInstance(int[] notes, int amount)
        {
            if (instance == null)
                instance = new Banker(notes, amount);
            return instance;
        }
        public static Banker instance = null;


        private Banker(int[] notes, int amount )
        {
            this.notes = notes;
            this.amount = amount;
            exist = true;
        }

        private static bool exist = false;



        public int[] Calculate()
        {
            int[] noteCounter = new int[this.notes.Length];
            int total, i=0;
            int amt = MyRound(amount);

            while (amt > 0)
            {
                total = (int)amt / notes[i];
                noteCounter[i] = total;
                amt = amt - (total * notes[i]);
                i++;
            }

            return noteCounter;
        }


        private int MyRound(int amount)
        {
            int amt= amount;
            int min = notes.Min();

            if (min == 1)
                return  amt;
            if (min == 5)
                return  (amt + 2) / 5 * 5;
            if (min == 10)
                return (amt + 4) / 10 * 10;

            return -1;
        }

    }
}
