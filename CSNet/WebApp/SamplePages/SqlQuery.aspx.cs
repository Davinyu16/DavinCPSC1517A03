﻿using NorthwindSystem.BLL;
using NorthwindSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class SqlQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (!Page.IsPostBack)
            {
                BindCategoryList();
            }
        }

        protected void BindCategoryList()
        {
            //this will be a standard lookup for the Category record
            try
            {
                CategoryController sysmgr = new CategoryController();
                List<Category> info = null;
                info = sysmgr.Categories_List();
                info.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                CategoryList.DataSource = info;
                CategoryList.DataTextField = nameof(Category.CategoryName);
                CategoryList.DataValueField = nameof(Category.CategoryID);
                CategoryList.DataBind();
                CategoryList.Items.Insert(0, "select...");
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (CategoryList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Select a category to view it's products";
            }
            else
            {
                //standard lookup
                {
                    try
                    {
                        ProductController sysmgr = new ProductController();
                        List<Category> info = null;
                        info = sysmgr.Products_FindByCategory(int.Parse(CategoryList.SelectedValue());
                        info.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                        ProductList.DataSource = info;
                        ProductList.DataBind();
                    }
                    catch (Exception ex)
                    {
                        MessageLabel.Text = ex.Message;
                    }
                }
            }
        }
    }
}