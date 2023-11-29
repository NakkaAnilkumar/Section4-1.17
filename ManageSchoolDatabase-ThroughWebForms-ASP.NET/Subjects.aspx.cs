﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManageSchoolDatabase_ThroughWebForms_ASP.NET
{
    public partial class Subjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change if needed
        }

        private void BindGridView()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=SUNNYLAPPY\\SQLEXPRESS;Initial Catalog=SCHOOLDB;Integrated Security=True;Encrypt=False"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Subjects", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                GridView1.DataSource = reader;
                GridView1.DataBind();

                reader.Close();
            }
        }
    }
}