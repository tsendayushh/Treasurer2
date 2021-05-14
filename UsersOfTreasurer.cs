﻿using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Treasurer2
{
    public partial class UsersOfTreasurer : DevExpress.XtraEditors.XtraUserControl
    {
        MyDatabase db = new MyDatabase();
        PRODUCTS product = new PRODUCTS();


        private static UsersOfTreasurer _instance;

        public static UsersOfTreasurer Instance
        {
            get
            { 
                if (_instance == null)
                    _instance = new UsersOfTreasurer();
                return _instance;
            }
        }



        #region UsersOfTreasurerFormLoad
        public UsersOfTreasurer()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            //sqlDataSource2.FillAsync();
            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.users_of_treasurer;", db.getConnection());
            gridControlUsers.DataSource = db.getDataTable(command);
        }
        #endregion


        #region  toolStripButtonAddClickEvent
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUForm = new AddUserForm();
            addUForm.Show(this);
        }
        #endregion


        #region  toolStripButtonEdit_Click
        public void toolStripButtonEdit_Click(object sender, EventArgs e)
        {

            updateUserFormDataSet();
            
        }
        #endregion


        #region updateUserFormDataSet
        public void updateUserFormDataSet()
        {
            UpdateUserForm updateUForm = new UpdateUserForm();
            if (gridView1.GetFocusedRowCellValue(coluser_id) != null)
            {
                string username = Convert.ToString(gridView1.GetFocusedRowCellValue(colusername));
                updateUForm.glueUsername.Text = username;
                updateUForm.updateUserFormDataSet(username);
                if (!updateUForm.IsDisposed)
                    updateUForm.Show(this);
            }
            else
            {
                updateUForm.Show(this);
            }
            
        }
        #endregion


        #region toolStripButtonDelete_Click 
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(coluser_id) != null)
            {
                int uid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(coluser_id));
                product.deleteProduct(uid);
            }
        }
        #endregion


        #region toolStripButtonRefresh_Click
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            UsersOfTreasurer usersOfTreasurer = new UsersOfTreasurer();

            toolStripTextBoxSearch.Text = "";

            MySqlCommand command = new MySqlCommand("SELECT * FROM usersdb.users_of_treasurer;", db.getConnection());
            DataTable table = db.getDataTable(command);
            gridControlUsers.DataSource = table;
        }
        #endregion


        #region toolStripButtonSearch_Click
        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {

            if (toolStripTextBoxSearch.Text != "")
            {
                string searchInput = toolStripTextBoxSearch.Text;

                MySqlCommand command = new MySqlCommand("CALL `usersdb`.`search_user`('%" + searchInput + "%');", db.getConnection());

                DataTable table = db.getDataTable(command);

                if (table.Rows.Count > 0)
                {
                    gridControlUsers.DataSource = table;

                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("'" + searchInput + "' утгатай хайлтын илэрц олдсонгүй", "Олдсонгүй", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeConnection();
                }

            }
            
        }
        #endregion


        #region gridControlUsers_DoubleClick
        private void gridControlUsers_DoubleClick(object sender, EventArgs e)
        {
            updateUserFormDataSet();
        }

        #endregion

    }
}
