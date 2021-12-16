using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientWcfService1WinFormsApp.Forms
{
    public partial class FormHealthData : Form
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
        public FormHealthData()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectAllUserData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectOxygenData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectHeartData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectBloodData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectStepsData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string allData = obj.SelectStairsData();
            dt = JsonConvert.DeserializeObject<DataTable>(allData);
            dataGridView1.DataSource = dt;
        }
    }
}
