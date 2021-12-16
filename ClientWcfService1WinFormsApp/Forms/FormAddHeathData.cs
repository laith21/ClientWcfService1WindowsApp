using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace ClientWcfService1WinFormsApp.Forms
{
    public partial class FormAddHeathData : Form
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client(); // Add service reference 

        public FormAddHeathData()
        {
            InitializeComponent();
            showdata();
        }

        private void showdata()  // to show the data in the DataGridView  
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectAllUserData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.getwatchdata objgetwatchdata = new ServiceReference1.getwatchdata(); // add type reference  
            objgetwatchdata.Oxygen_Saturation = textBoxOxygen.Text;
            objgetwatchdata.Heart_Rate = textBoxHeart.Text;
            objgetwatchdata.Blood_Pressure = textBoxBlood.Text;
            objgetwatchdata.Steps_Walked = textBoxSteps.Text;
            objgetwatchdata.Stairs_Climbed = textBoxStairs.Text;
            obj.InsertUserData(objgetwatchdata);
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Pull data from gridview and insert data into a client Database
            string constring = @"Data Source=DESKTOP-AFE7T16;Initial Catalog=ClientAppleWatchData;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            try
            {
                con.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO ClientHealthData VALUES (@Oxygen_Saturation,@Heart_Rate,@Blood_Pressure,@Steps_Walked,@Stairs_Climbed)", con))
                    {
                        cmd.Parameters.AddWithValue("@Oxygen_Saturation", row.Cells["Oxygen_Saturation"].Value);
                        cmd.Parameters.AddWithValue("@Heart_Rate", row.Cells["Heart_Rate"].Value);
                        cmd.Parameters.AddWithValue("@Blood_Pressure", row.Cells["Blood_Pressure"].Value);
                        cmd.Parameters.AddWithValue("@Steps_Walked", row.Cells["Steps_Walked"].Value);
                        cmd.Parameters.AddWithValue("@Stairs_Climbed", row.Cells["Stairs_Climbed"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                MessageBox.Show("Successfully Saved!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
