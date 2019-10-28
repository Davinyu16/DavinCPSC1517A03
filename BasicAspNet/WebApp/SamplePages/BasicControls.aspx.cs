using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //global variable available to the entire page and will
        // temporarily represent data from the database
        public static List<DDLClass> DataCollection;

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
                //load the DDL on the 1st pass
                //create a new instance of the DDLClass
                //create 4 entries for the collection
                //place the collection into the DDL
                DataCollection = new List<DDLClass>();
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT1508"));
                DataCollection.Add(new DDLClass(4, "DMIT2018"));

                //sort the data collection by program course name
                //syntax collectionname.Sort((x,y) => x.fieldname.CompareTo(y.filename))
                //collectionname is where you List<T> resides
                //(x,y) represent any two values (records) in your collection at any point in time
                // => (lamda sign) can be thought of as "Do the following to x and y"
                //our delagate for the lamda is comparing x and y on fieldname 
                // x CompareTo y is an ascending sort
                // y CompareTo x is a descending sort
                DataCollection.Sort((x, y) => x.DisplayField.CompareTo(y.DisplayField));

                //steps in loading your DDL 
                //a) assign the data source to the control
                CollectionChoiceList.DataSource = DataCollection;
                //b) indicate the display field to the control
                // <option value=valuefield>displayfield</option>
                CollectionChoiceList.DataTextField = "DisplayField"; //non object style
                //c) indicate the value field to the control 
                CollectionChoiceList.DataValueField = nameof(DDLClass.ValueField); //object style
                //d) physically bind the data to the control
                CollectionChoiceList.DataBind();

                //optional prompt line??
                CollectionChoiceList.Items.Insert(0, "select...");

            }
        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "you pressed the button Submit";

            //to grab the contents of a control will DEPEND on the control access type
            //for Textbox, Label, Literal use .Text
            //for Lists (RadioButtonList, DropDownList) you may use
            // .SelectedValue, .SelectedIndex, .SelectedItem
            //for CheckBox use .Checked

            //for the most part, all data from a control returns as a STRING
            //except for boolean type controls

            //since the control is on the "RIGHT" side of an assignment statement
            //  The object instance uses the GET
            string submitchoice = NumberChoice.Text;

            if (string.IsNullOrEmpty(submitchoice))
            {
                //"LEFT" side uses property's SET
                MessageLabel.Text = "You did not enter a value for your program choice";
                ResetFields();
            }
            else
            {
                //You can set the radiobuttonlist choice by either using 
                //  .SelectedValue or .SelectedIndex or .SelectedItem 
                //it is BEST to use .SelectedValue
                ChoiceList.SelectedValue = submitchoice;

                //place a check mark in the checkbox if the chosen course
                //is a program
                if (submitchoice.Equals("2") || submitchoice.Equals("4"))
                {
                    ProgrammingCourseActive.Checked = true;
                    AlterLabel.ForeColor = System.Drawing.Color.BlueViolet;
                }
                else
                {
                    ProgrammingCourseActive.Checked = false;
                    AlterLabel.ForeColor = System.Drawing.Color.Black;
                }

                //DDL can be positioned using
                // .SelectedValue or .SelectedIndex or .SelectedItem
                //it is BEST to use .SelectedValue
                CollectionChoiceList.SelectedValue = submitchoice;

                //demonstration of what is obtained by the different .Selectxxxx
                //.SelectedValue returns the value of the DataValueField
                //.SelectedIndex returns the index value of the selected row
                //.SelectedItem returns the value of the DisplayText
                DisplayDataRO.Text = CollectionChoiceList.SelectedItem.Text
                    + " at index " + CollectionChoiceList.SelectedIndex
                    + " having a value of " + CollectionChoiceList.SelectedValue;
            }
        }

        protected void ColectionSubmit_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "you pressed the link button Selection Submit";

        }

        protected void ResetFields()
        {
            DisplayDataRO.Text = "";
            ProgrammingCourseActive.Checked = false;
            ChoiceList.ClearSelection();
            //ChoiceList.SelectedIndex = -1;    optional way of deselecting
            CollectionChoiceList.ClearSelection();
            AlterLabel.ForeColor = System.Drawing.Color.Black;
        }


    }
}