using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using DataManager;
using MySql.Data.MySqlClient;
using Common.StringUtilities;


namespace FMSPropertyInventory 
{
    public partial class frmLandInventory : Form
    {
        public frmLandInventory()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void cboxMOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMOP.Text == "PURCHASED")
            {
               
            }
            else
            {
              
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        
        }

        private void frmLandInventory_Load(object sender, EventArgs e)
        {


            //m_set.Query = @"SELECT * tbl_prop_inv";

            //if (m_set.Execute())
            //    if (m_set.Read())
            //    {
            //        //id = m_set.GetString(0);
            //    }
            //m_set.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                string connectionString = "server=localhost;uid=root;pwd=daraga2024;database=fms_property_inventory;";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.ConnectionString = connectionString;
                con.Open();
                string sql = "Select * from tbl_prop_inv";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Connected");
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
