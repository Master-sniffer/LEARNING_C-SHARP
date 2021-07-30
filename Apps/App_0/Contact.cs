using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Contacts;

namespace WinFormsApp1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        ContactsClass C = new ContactsClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the value from the input field
            C.NamesBox = NameBox.Text;
            C.NumbersBox = NumberBox.Text;
            C.SurnamesBox = SurnameBox.Text;
            C.textsBox1 = textBox1.Text; // adress
            C.ChoosesGender = ChooseGender.Text;

            // Inserting data in database

            bool Success = C.Insert(C);
            if (Success == true)
            {
                MessageBox.Show("Done and Done !\nSuccessfully inserted");
                Clear();
            } else
            {
                MessageBox.Show("You fucked up");
            }

            // Load data on datagridview

            DataTable DT = C.Select();
            GridView.DataSource = DT;

        }

        private void Updating_Click(object sender, EventArgs e)
        {
            //Get the data from textboxes
            C.ContactsBox = int.Parse(ContactBox.Text);
            C.NamesBox = NameBox.Text;
            C.NumbersBox = NumberBox.Text;
            C.SurnamesBox = SurnameBox.Text;
            C.textsBox1 = textBox1.Text; // adress
            C.ChoosesGender = ChooseGender.Text;

            //Check if everything works
            bool success = C.Update(C);
            if (success == true)
            {
                MessageBox.Show("Karikukasai");
                Clear();
                DataTable DT = C.Select();
                GridView.DataSource = DT;
            } else
            {
                MessageBox.Show("You Fucked Up");
            }

        }

        private void Deleting_Click(object sender, EventArgs e)
        {
            C.ContactsBox = Convert.ToInt32(ContactBox.Text);
            bool success = C.Delete(C);
            if (success == true)
            {
                MessageBox.Show("deleted allah");
                Clear();
                DataTable DT = C.Select();
                GridView.DataSource = DT;
            }
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            DataTable DT = C.Select();
            GridView.DataSource = DT;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allah Loves you, Habibi");
            this.Close(); // Close the app
        }

        // Clearing the space after entering all info
        public void Clear()
        {
            NameBox.Text="";
            NumberBox.Text="";
            SurnameBox.Text="";
            textBox1.Text=""; // adress
            ChooseGender.Text="";
            ContactBox.Text = "";
        }

        private void GridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the data From the Grid View and load it into the App
            // Identify the row on which one the mouse is clicked
            int rowindex = e.RowIndex;
            NameBox.Text = GridView.Rows[rowindex].Cells[1].Value.ToString();
            NumberBox.Text = GridView.Rows[rowindex].Cells[3].Value.ToString();
            SurnameBox.Text = GridView.Rows[rowindex].Cells[2].Value.ToString();
            textBox1.Text = GridView.Rows[rowindex].Cells[4].Value.ToString();
            ChooseGender.Text = GridView.Rows[rowindex].Cells[5].Value.ToString();
            ContactBox.Text = (GridView.Rows[rowindex].Cells[0].Value.ToString());
        }

        private void Clearing_Click(object sender, EventArgs e)
        {
            Clear();
        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void ForSearching_TextChanged(object sender, EventArgs e)
        {
            // Get the value from the text box
            string words = ForSearching.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Table_0 WHERE FirstName LIKE '%" + words + "%' OR Surname LIKE '%" + words + "%' OR ContactNumb LIKE '%" + words + "%' OR Address LIKE '%" + words + "%' ", conn);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            GridView.DataSource=DT;
        }
    }
}
