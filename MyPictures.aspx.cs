using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _myPictures : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            Image1.Visible = false;
            CheckBox1.Visible = false;
            RadioButtonList1.Visible = false;
            Label2.Visible = false;
            Label1.Visible = false;
            DropDownList2.Visible = false;
            Label3.Visible = false;

        }
        if (DropDownList1.SelectedIndex == 1)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/a.jpg";
        }
        if (DropDownList1.SelectedIndex == 2)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/b.jpg";
        }
        if (DropDownList1.SelectedIndex == 3)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/c.jpg";
        }
        if (DropDownList1.SelectedIndex == 4)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/d.jpg";
        }
        if (DropDownList1.SelectedIndex == 5)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/e.jpg";
        }
        if (DropDownList1.SelectedIndex == 6)
        {
            Image1.Visible = true;
            CheckBox1.Visible = true;
            Label3.Visible = true;
            Image1.ImageUrl = "images/f.jpg";
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            DropDownList2.Visible = true;
            RadioButtonList1.Visible = true;
        }
        else
        {
            Image1.BorderWidth = 0;
            Label1.Visible = false;
            Label2.Visible = false;
            DropDownList2.Visible = false;
            RadioButtonList1.Visible = false;
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            Image1.BorderColor = System.Drawing.Color.Brown;
        }
        if (RadioButtonList1.SelectedIndex == 1)
        {
            Image1.BorderColor = System.Drawing.Color.Blue;
        }
        if (RadioButtonList1.SelectedIndex == 2)
        {
            Image1.BorderColor = System.Drawing.Color.Aqua;
        }
        if (RadioButtonList1.SelectedIndex == 3)
        {
            Image1.BorderColor = System.Drawing.Color.Red;
        }
        if (RadioButtonList1.SelectedIndex == 4)
        {
            Image1.BorderColor = System.Drawing.Color.Green;
        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string strr = DropDownList2.SelectedItem.Value;
            switch (strr)
            {
                case "a1":
                    Image1.BorderWidth = 1;
                    break;

                case "a2":
                    Image1.BorderWidth = 2;
                    break;

                case "a3":
                    Image1.BorderWidth = 3;
                    break;

                case "a4":
                    Image1.BorderWidth = 4;
                    break;

                case "a5":
                    Image1.BorderWidth = 5;
                    break;

            }
    }
}