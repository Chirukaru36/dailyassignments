using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=sqlserver;Integrated Security=True;");

            SqlCommand cmd = new SqlCommand("select * from department", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Dept>deptlist = new List<Dept>();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    Dept d = new Dept();
                    d.Deptno = Convert.ToInt32(dr["deptid"]);
                    d.DeptName = dr["deptname"].ToString();
                    d.DeptLoc = dr["deptLoc"].ToString() ;
                    deptlist.Add(d);
 
                }
            }

            conn.Close();
            conn.Dispose();
            deptdatadisplay.DataSource = deptlist;

            
        }
    }
}
