﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //this changes the existing string from the other page
            HelloString.Text = "boo";
            HelloString.ForeColor = System.Drawing.Color.Crimson;
            HelloString.Font.Size = 100;
        }
    }
}