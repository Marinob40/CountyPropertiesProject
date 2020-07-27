using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidtermExam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Will display different properties according to option chosen in dropdown.
        //Will display images of property and information when property is clicked
        protected void ddlCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCounties.SelectedItem.Value == "1")
            {
                Image1.ImageUrl = "../Images/Columbia1Small.jpg";
                Image2.ImageUrl = "../Images/Columbia2Small.jpg";
                Image3.ImageUrl = "../Images/Columbia3Small.jpg";

                Label1.Text = "Price:" + " " + string.Format("{0:C}", 353900);
                Label2.Text = "Square Feet: 3146sqft";
                Label3.Text = "Price:" + " " + string.Format("{0:C}", 215000);
                Label4.Text = "Square Feet: 1,930sqft";
                Label5.Text = "Price:" + " " + string.Format("{0:C}", 198000);
                Label6.Text = "Square Feet: 1,645sqft";

                if (Image1.ImageUrl == "../Images/Columbia1Small.jpg")
                {
                    HyperLink1.NavigateUrl = "Columbia1.aspx";
                }
                if (Image2.ImageUrl == "../Images/Columbia2Small.jpg")
                {
                    HyperLink2.NavigateUrl = "Columbia2.aspx";
                }
                if (Image3.ImageUrl == "../Images/Columbia3Small.jpg")
                {
                    HyperLink3.NavigateUrl = "Columbia3.aspx";
                }
            }
            else if (ddlCounties.SelectedItem.Value == "2")
            {
                Image1.ImageUrl = "../Images/Richmond1Small.jpg";
                Image2.ImageUrl = "../Images/Richmond2Small.jpg";
                Image3.ImageUrl = "../Images/Richmond3Small.jpg";

                Label1.Text = "Price:" + " " + string.Format("{0:C}", 269900);
                Label2.Text = "Square Feet: 2,867sqft";
                Label3.Text = "Price:" + " " + string.Format("{0:C}", 129900);
                Label4.Text = "Square Feet: 2,275sqft";
                Label5.Text = "Price:" + " " + string.Format("{0:C}", 124167);
                Label6.Text = "Square Feet: 2,392sqft";

                if (Image1.ImageUrl == "../Images/Richmond1Small.jpg")
                {
                    HyperLink1.NavigateUrl = "Richmond1.aspx";
                }
                if (Image2.ImageUrl == "../Images/Richmond2Small.jpg")
                {
                    HyperLink2.NavigateUrl = "Richmond2.aspx";
                }
                if (Image3.ImageUrl == "../Images/Richmond3Small.jpg")
                {
                    HyperLink3.NavigateUrl = "Richmond3.aspx";
                }

            }
            else if (ddlCounties.SelectedItem.Value == "3")
            {
                Image1.ImageUrl = "../Images/Lincoln1Small.jpg";
                Image2.ImageUrl = "../Images/Lincoln2Small.jpg";
                Image3.ImageUrl = "../Images/Lincoln3Small.jpg";

                Label1.Text = "Price:" + " " + string.Format("{0:C}", 100000);
                Label2.Text = "Square Feet: 1,008sqft";
                Label3.Text = "Price:" + " " + string.Format("{0:C}", 199900);
                Label4.Text = "Square Feet: 1,152sqft";
                Label5.Text = "Price:" + " " + string.Format("{0:C}", 250000);
                Label6.Text = "Square Feet: 1,824sqft";

                if (Image1.ImageUrl == "../Images/Lincoln1Small.jpg")
                {
                    HyperLink1.NavigateUrl = "Lincoln1.aspx";
                }
                if (Image2.ImageUrl == "../Images/Lincoln2Small.jpg")
                {
                    HyperLink2.NavigateUrl = "Lincoln2.aspx";
                }
                if (Image3.ImageUrl == "../Images/Lincoln3Small.jpg")
                {
                    HyperLink3.NavigateUrl = "Lincoln3.aspx";
                }
            }

        }
    }
}