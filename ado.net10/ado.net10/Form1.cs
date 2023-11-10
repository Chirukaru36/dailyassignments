using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ado.net10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-4D61AIG\\SQLEXPRESS;Integrated Security=True;Database=northwind");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employer", cn);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "Employer");

            DataTable dt = new DataTable();
            dt = ds.Tables["Employer"];
            dataGridView1.DataSource = dt;
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-4D61AIG\\SQLEXPRESS;Integrated Security=True;Database=northwind");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employer", cn);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "Employer");

            DataRow row = ds.Tables["Employer"].NewRow();
            row["CompanyName"] = textcompanyname.Text.Trim();
            row["City"] = textcity.Text.Trim();
            row["ContactPerson"] = textcontactperson.Text.Trim();

            ds.Tables["Employer"].Rows.Add(row);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Employer"]);
            MessageBox.Show("Inserted Successfully...");

            Form1_Load(sender, e);



        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-4D61AIG\\SQLEXPRESS;Integrated Security=True;Database=northwind");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employer", cn);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "Employer");
            DataRow found = ds.Tables["Employer"].Rows.Find(Convert.ToInt32(textcompanyid.Text));
            if (found != null)
            {
                found["CompanyName"] = textcompanyname.Text.Trim();
                found["City"] = textcity.Text.Trim();
                found["ContactPerson"] = textcontactperson.Text.Trim();

                SqlCommandBuilder bldr = new SqlCommandBuilder(da);
                da.Update(ds.Tables["Employer"]);
                Form1_Load(sender, e);
                MessageBox.Show("Updated Successfully...");

            }
            else
            {

                MessageBox.Show("Enter a valid company ID");
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-4D61AIG\\SQLEXPRESS;Integrated Security=True;Database=northwind");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employer", cn);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "Employer");
            DataRow found = ds.Tables["Employer"].Rows.Find(Convert.ToInt32(textcompanyid.Text));
            if (found != null)
            {
                textcompanyname.Text = found["CompanyName"].ToString();
                textcity.Text = found["City"].ToString();
                textcontactperson.Text = found["ContactPerson"].ToString();

                MessageBox.Show("records are found successfully");

            }

            else
            {
                textcompanyname.Text = "";
                textcity.Text = "";
                textcontactperson.Text = "";
                MessageBox.Show("no records are found");

            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-4D61AIG\\SQLEXPRESS;Integrated Security=True;Database=northwind");
            SqlDataAdapter da = new SqlDataAdapter("select * from Employer", cn);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.Fill(ds, "Employer");
            DataRow found = ds.Tables["Employer"].Rows.Find(Convert.ToInt32(textcompanyid.Text));
            if (found != null)
            {
                textcompanyname.Text = found["CompanyName"].ToString();
                textcity.Text = found["City"].ToString();
                textcontactperson.Text = found["ContactPerson"].ToString();

                DialogResult dialogresult = MessageBox.Show("Found R u sure to delete?", "Confirmation from User", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == dialogresult)
                {
                    found.Delete();
                    SqlCommandBuilder bldr = new SqlCommandBuilder(da);
                    da.Update(ds.Tables["Employer"]);
                    MessageBox.Show("Deleted Successfully....");
                    textcompanyname.Text = "";
                    textcity.Text = "";
                    textcontactperson.Text = "";

                    Form1_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Ok... I am not deleting");
                }


            }
        }
    }
}

