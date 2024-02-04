using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace petadoption
{
    public partial class pdelete : Form
    {



        public pdelete()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();


        }

        public void RefreshDataGridView ()
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=pet_adoption; password=";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string query = "SELECT ID, Name, Breed, Age, Details, Picture FROM pet_adopt";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns before setting the DataSource
                            dataGridView1.Columns.Clear();

                            // Set the DataTable as the DataSource for the dataGridView1
                            dataGridView1.DataSource = dt;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                


                int idIndex = dataGridView1.Columns["ID"].Index;
                int nameIndex = dataGridView1.Columns["Name"].Index;

                // Get the ID and Name values from the selected row
                int selectedId = Convert.ToInt32(selectedRow.Cells[idIndex].Value);
                string selectedName = selectedRow.Cells[nameIndex].Value.ToString();

                // Update visibility of PictureBox controls based on the selected ID
                pictureBox1.Visible = (selectedId == 1);
                pictureBox3.Visible = (selectedId == 2);
                pictureBox2.Visible = (selectedId == 3);
                pictureBox4.Visible = (selectedId == 4);
                pictureBox5.Visible = (selectedId == 5);
                pictureBox6.Visible = (selectedId == 6);



                pictureBox1.Visible = (selectedName == "Lucky");
                pictureBox2.Visible = (selectedName == "Panda");
                pictureBox3.Visible = (selectedName == "Doraemon");
                pictureBox4.Visible = (selectedName == "Iro");
                pictureBox5.Visible = (selectedName == "Masho");
                pictureBox6.Visible = (selectedName == "Alpha");


                int breedIndex = dataGridView1.Columns["Breed"].Index;
                int ageIndex = dataGridView1.Columns["Age"].Index;
                int detailsIndex = dataGridView1.Columns["Details"].Index;

                // Display values in labels
                label5.Text = selectedRow.Cells[nameIndex].Value.ToString();
                label6.Text = selectedRow.Cells[breedIndex].Value.ToString();
                label7.Text = selectedRow.Cells[ageIndex].Value.ToString();
                label8.Text = selectedRow.Cells[detailsIndex].Value.ToString();
            }
            else
            {
                
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int idIndex = dataGridView1.Columns["ID"].Index;
                    int selectedId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[idIndex].Value);

                    // Delete the row from the DataTable bound to the DataGridView
                    DataTable dt = (DataTable)dataGridView1.DataSource;
                    DataRow[] rows = dt.Select($"ID = {selectedId}");
                    foreach (DataRow row in rows)
                    {
                        // Delete the row from the DataTable
                        dt.Rows.Remove(row);

                        // Delete the row from the database
                        DeleteRecordFromDatabase(selectedId);
                    }

                    // Update the DataGridView
                    dataGridView1.Refresh();

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecordFromDatabase(int recordId)
        {
            string mysqlCon = "127.0.0.1; user=root; database=pet_adoption; password=";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM pet_adopt WHERE ID = {recordId}";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addPet addPetForm = new addPet();
            addPetForm.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
