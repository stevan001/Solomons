using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProdigyProducts.BLL.Services;

namespace Solomons.Web
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Name:{0} <br />", tbxName.Text);
                sb.AppendLine();
                sb.AppendFormat("Email:{0} <br />", tbxEmail.Text);
                sb.AppendLine();
                sb.AppendLine("Message:<br />");
                sb.AppendLine(tbxMessage.Text);
                EmailService.SendMail("stevan.thomas@hotmail.com","Solomons",tbxSubject.Text,sb.ToString());
                lblStatuts.Text = "Your Message has been sent!";
            }
            catch (Exception exception)
            {
                lblStatuts.Text = "There was a problem sending your message. Error :"+ exception.Message; 

            }
        }
    }
}