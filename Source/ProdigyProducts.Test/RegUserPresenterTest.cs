using System;
using System.Web.UI.WebControls;
using NUnit.Framework;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Views;
using Rhino.Mocks;
using Rhino.Mocks.Interfaces;

namespace ProdigyProducts.Test
{
    [TestFixture]
    public class RegUserPresenterTest
    {
        private IRegisterUserView _view;
       // private IRegisterUserPresnter _presnter; 

        [Test]
        public void ShouldCreateANewUser()
        {
            MockRepository mocks = new MockRepository();
            _view = (IRegisterUserView) mocks.StrictMock<IRegisterUserView>();
           
          
           RegisterUserPresenter presenter = new RegisterUserPresenter(_view);
            //Button btn = (Button)mocks.StrictMock(typeof (System.Web.UI.WebControls.Button));
              //Expect.Call(_view.RegisterButton).Return(btn);
             
                Expect.Call(_view.FirstName).Return("Stevan");
                Expect.Call(_view.LastName).Return("Thomas");
                Expect.Call(_view.Address).Return("Home");
                Expect.Call(_view.BillingAddress).Return("Home");
                //Expect.Call(_view.Phone).Return("123123123");
                Expect.Call(_view.Email).Return("stevan.thomas@hotmail.com");
             

            
                _view.RegisterEvent += null;
                IEventRaiser raiser = LastCall.IgnoreArguments().GetEventRaiser();
             
            mocks.ReplayAll();
             mocks.Ordered();
            raiser.Raise(_view,EventArgs.Empty);
            Assert.AreEqual("Stevan",_view.FirstName);
            
            mocks.VerifyAll();
        }


        [Test]
        public void ShoulcCreateDataAccount()
        {
            
        }


        [Test]
        public void ShouldCreatePresentationAccount()
        {
            
        }

        [Test]
        public void ShouldEmailRegistrationLink()
        {
            
        }

        [Test]
        public void ShouldConfirmEmailCodeandRegisterUser()
        {
            
        }
        [Test]
        public void ShouldModifyAccount()
        {
            
        }

        [Test]
        public void ShouldChancePassword()
        {
            
        }
    }
}