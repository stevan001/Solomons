using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Views;

namespace Solomons.Web.Store
{
    public partial class Register : System.Web.UI.Page, IRegisterUserView
    {
        private RegisterUserPresenter _presenter;
       // public delegate void ButtonClickHandler(object sender, EventArgs e);
       // public event ButtonClickHandler _myRegisterEvent;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnInit(EventArgs e)
        {
            _presenter = new RegisterUserPresenter(this);
            
            base.OnInit(e);
        }

        public string FirstName
        {
            get { return TextBox1.Text; }
        }

        public string LastName
        {
            get { return TextBox2.Text; }
        }

        public string Email
        {
            get { return TextBox3.Text;}
        }

        public string Phone
        {
            get { return TextBox4.Text; }
        }

        public string Address
        {
            get { return TextBox5.Text; }
        }

        public string BillingAddress
        {
            get { return TextBox6.Text; }
        }

        

        public event EventHandler RegisterEvent;

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RegisterEvent != null)
                RegisterEvent(this, EventArgs.Empty);
        }

      
    }
}