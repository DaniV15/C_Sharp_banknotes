using BankNotes_Calculator.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankNotes_Calculator
{
    public partial class MainForm : Form
    {

        BankNotes notes;
        Banker banker;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            AnswerList.Items.Clear();
            notes.setNoteList(currencyList.SelectedItem.ToString());
            banker.Amount = (int)NumAmount.Value;
            int[] result = banker.Calculate();

            for (int i = 0; i < notes.NoteList.Length; i++)
            {
                if(result[i] > 0)
                AnswerList.Items.Add(result[i] + "x\t" + notes.NoteList[i] + " " + notes.Devisa.ToString());
            }

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            currencyList.SelectedItem = "HUF";
            notes = new BankNotes(currencyList.SelectedItem.ToString());
            banker = Banker.GetInstance(notes.NoteList, 0);
            LoadNotes();
            btn_Calculate.Enabled = true;

        }

        private void LoadNotes()
        {
            NotesList.Items.Clear();
            for(int i= 0; i < notes.NoteList.Length; i++)
            NotesList.Items.Add (notes.NoteList[i]);

        }

        private void currencyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Calculate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Calculate.Enabled = true;
            notes.setNoteList(currencyList.SelectedItem.ToString());
            LoadNotes();
            banker.Notes = notes.NoteList;
        }
    }
}
