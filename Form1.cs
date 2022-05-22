using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeNoteApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            preNotes.DataSource = notes;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[preNotes.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[preNotes.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
                notes.Rows[preNotes.CurrentCell.RowIndex]["Note"] = txtNote.Text;
            }
            else
            {
                notes.Rows.Add(txtTitle.Text, txtNote.Text);
            }
            txtTitle.Text = " ";
            txtNote.Text = " ";
            editing = false;

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            txtTitle.Text = notes.Rows[preNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtNote.Text = notes.Rows[preNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            txtTitle.Text = " ";
            txtNote.Text = " ";

        }

        private void preNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = notes.Rows[preNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtNote.Text = notes.Rows[preNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
