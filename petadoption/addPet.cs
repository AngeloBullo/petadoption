using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace petadoption
{
    public partial class addPet : Form


    {



        private string imageFilePath;
        public addPet()
        {
            InitializeComponent();
        }

        private void uploadpetpicbBox_Click(object sender, System.EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void ageTxtbox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void nameAptb1_TextChanged(object sender, System.EventArgs e)
        {

        }

        public void RefreshDataGridView()
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

        private void addPetBtn_Click(object sender, EventArgs e)
        {
            // Get information from textboxes
            string name = nameAptb1.Text;
            string breed = breedAptb2.Text;
            string age = ageTxtbox.Text;
            string description = descriptionTextbox.Text;

            // Validate that all required fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(breed) || string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new row for the DataGridView
            DataGridViewRow newRow = new DataGridViewRow();

            if (dataGridView1.Columns.Count == 0)
            {
                // If there are no columns, create them based on the data you want to display
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Breed", "Breed");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Description", "Description");
            }
            newRow.CreateCells(dataGridView1);

            // Set values to the cells in the DataGridView row
            newRow.Cells[0].Value = name;
            newRow.Cells[1].Value = breed;
            newRow.Cells[2].Value = age;
            newRow.Cells[3].Value = description;

            // Add the new row to the DataGridView
            dataGridView1.Rows.Add(newRow);

            string mysqlCon = "server=127.0.0.1; user=root; database=pet_adoption; password=";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlCon))
                {
                    connection.Open();

                    string query = "INSERT INTO pet_adopt (Name, Breed, Age, Details, Picture) VALUES (@Name, @Breed, @Age, @Details, @Picture)";


                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Breed", breed);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Details", description);
                        cmd.Parameters.AddWithValue("@Picture", imageFilePath);


                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           

            // Clear the textboxes and image
            nameAptb1.Clear();
            breedAptb2.Clear();
            ageTxtbox.Clear();
            descriptionTextbox.Clear();
            uploadpetpicbBox.Image = null;

            MessageBox.Show("Pet information added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void uploadBtn_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";

            if (openfd.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openfd.FileName;
                uploadpetpicbBox.Image = new Bitmap(imageFilePath);
                uploadpetpicbBox.ImageLocation = openfd.FileName;
                uploadpetpicbBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }


            


        }

        private void Back_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            pdelete pdeleteForm = new pdelete();
            pdeleteForm.ShowDialog();
            this.Hide();
           
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                string picturePath = dataGridView1.Rows[e.RowIndex].Cells["image"].Value.ToString();
                pictureBox6.ImageLocation = picturePath;
            }
        }

    }
}
