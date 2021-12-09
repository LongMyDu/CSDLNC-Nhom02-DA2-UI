﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoaYeuThuong
{
    public partial class GQForm : Form
    {
        // Connection string (@ represents this is a string)
        string strCon = @"Data Source=DESKTOP-MNUAD46\SQLEXPRESS;Initial Catalog=DB_HoaYeuThuong;Integrated Security=True";

        // Connection object
        SqlConnection sqlCon = null;
        string searchText = "";
        int themeID = 0;
        int colorID = 0;

        public GQForm()
        {
            InitializeComponent();
        }

        private void LoadColor()
        {
            string query = @"SELECT * FROM MAUSAC";
            DataSet ds = RetrieveData(query);
            DataRow row = ds.Tables[0].NewRow();
            row["MaMau"] = 0;
            row["TenMau"] = "--Màu sắc--";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //set the ColorFilter control's data source/data table
            ColorFilter.DataSource = ds.Tables[0];
            ColorFilter.DisplayMember = "TenMau";
            ColorFilter.ValueMember = "MaMau";
        }

        private void LoadTheme()
        {
            string query = @"SELECT * FROM CHUDE";
            DataSet ds = RetrieveData(query);
            DataRow row = ds.Tables[0].NewRow();
            row["MaCD"] = 0;
            row["TenCD"] = "--Chủ đề--";
            ds.Tables[0].Rows.InsertAt(row, 0);

            //set the ColorFilter control's data source/data table
            ThemeFilter.DataSource = ds.Tables[0];
            ThemeFilter.DisplayMember = "TenCD";
            ThemeFilter.ValueMember = "MaCD";
        }

        private void LoadAllSPQT()
        {
            string query = @"SELECT * FROM SANPHAMQUATANG";
            DataSet ds = RetrieveData(query);

            //set DataGridView control to read-only
            grdData.ReadOnly = true;

            //set the DataGridView control's data source/data table
            grdData.DataSource = ds.Tables[0];
        }

        private void LoadMoney()
        {

        }

        private void ConnectDB()
        {
            try
            {
                // If null, then initialize
                if (sqlCon == null)
                {
                    // Pass a connection string when initializing a connection object
                    sqlCon = new SqlConnection(strCon);
                }

                // If closed, then open
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectDB()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        private DataSet RetrieveData(string query)
        {
            ConnectDB();
            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query, sqlCon);

            //Set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);
            DisconnectDB();
            return ds;
        }

        private void GQForm_Load(object sender, EventArgs e)
        {
            LoadColor();
            LoadTheme();
            LoadAllSPQT();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string condition = "WHERE";
            string query = null;
            bool isJoin = false;
            // if user enter search keyword
            if (!String.Equals(searchText, ""))
            {
                condition = condition + " " + "SPQT.TenSPQT LIKE '%" + searchText + "%'";
            }

            // if user use color filter
            if (colorID != 0)
            {
                isJoin = true;
                string getColor = "HT.MAUSACMaMau = " + colorID.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + getColor;
                }
                else
                {
                    condition = condition + " AND " + getColor;
                }    
            }

            if (themeID != 0)
            {
                string getTheme = "SPQT.CHUDEMaCD = " + themeID.ToString();
                if (String.Equals(condition, "WHERE"))
                {
                    condition = condition + " " + getTheme;
                }
                else
                {
                    condition = condition + " AND " + getTheme;
                }
            }

            if (!isJoin)
            {
                query = @"SELECT *
                FROM SANPHAMQUATANG SPQT
                ";
            }
            else
            {
                query = @"SELECT SPQT.MaSPQT, SPQT.TenSPQT, SPQT.MieuTaSPQT, SPQT.GiaBan, SPQT.GiaBanSauGiam, SPQT.CHUDEMaCD
                FROM SANPHAMQUATANG SPQT JOIN HOATUOI_SPQT HS ON (SPQT.MaSPQT = HS.SANPHAMQUATANGMaSPQT) JOIN HOATUOI HT ON (HS.HOATUOIMaHT = HT.MaHT)
                ";
            }
            
            if (!String.Equals(condition, "WHERE"))
            {
                query += condition;
            }

            DataSet ds = RetrieveData(query);

            //set DataGridView control to read-only
            grdData.ReadOnly = true;

            //set the DataGridView control's data source/data table
            grdData.DataSource = ds.Tables[0];
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBar.Text;
        }

        private void ColorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorID = ColorFilter.SelectedIndex;
        }

        private void ThemeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            themeID = ThemeFilter.SelectedIndex;
        }
    }
}


