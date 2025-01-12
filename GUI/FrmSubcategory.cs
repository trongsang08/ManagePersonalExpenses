﻿using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmSubcategory : Form
    {
        public FrmSubcategory()
        {
            InitializeComponent();
        }
        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        ManagePersonalExpensesContext context = new ManagePersonalExpensesContext();

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SubCategory subcategory = new SubCategory { SubCategoryId = int.Parse(txtID.Text) };
                SubCategory c = subCategoryRepository.GetSubCategoryById(subcategory.SubCategoryId);
                if (c != null)
                {
                    c.Name = txtName.Text;
                    c.Description = txtDes.Text;
                    c.CategoryId = int.Parse(txtCateID.Text);
                    subCategoryRepository.Update(c);
                    MessageBox.Show("Success");
                    load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddSubcategory add = new FrmAddSubcategory();
            add.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSubcategory_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            var subcategory = (from item in subCategoryRepository.GetAll()
                              select new { item.SubCategoryId, item.Name, item.Description , item.CategoryId })
                            .ToList();
            dgView.DataSource = subcategory;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", subcategory, "SubCategoryId");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", subcategory, "Name");

            txtDes.DataBindings.Clear();
            txtDes.DataBindings.Add("Text", subcategory, "Description");

            txtCateID.DataBindings.Clear();
            txtCateID.DataBindings.Add("Text", subcategory, "CategoryId");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                var sub = context.SubCategories.SingleOrDefault(item => item.SubCategoryId == int.Parse(txtID.Text));
                if (sub != null)
                {
                    context.SubCategories.Remove(sub);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("delete success");
                        load();

                    }
                    else
                    {
                        MessageBox.Show("delete failed");

                    }
                }
            
           

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.Show();
        }
    }
}
