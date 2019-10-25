﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this event will happen EACH and EVERY time your page is executed 
            //this event will happen BEFORE ANY of YOUR control events happen 
            //this is a great place to initialize items (controls) that are common 
            //  to many events and need to be done every time

            //example: old messages should be cleared out on every pass
            //      You can empty the MessageLabel control under each event
            //      OR do it once here for all events
            MessageLabel.Text = "";

            //this is a great place to do first time initialization of controls
            //(similar to the else side of IsPost from Razor)
            if (!Page.IsPostBack) //Page.IsPostBack == false
            {
                 
            }
        }
    }
}