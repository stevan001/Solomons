using System;
using NUnit.Framework;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;
using Rhino.Mocks;
using Rhino.Mocks.Interfaces;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class RegUserPresenterTest
    {
        private IRegisterUserView _view;
        private IRegistrationTask _task; 
        //private IRegisterUserPresnter _presnter; 

        [Test]
        public void ShouldCreateANewUser()
        {
           MockRepository mocks = new MockRepository();
            _view = (IRegisterUserView) mocks.StrictMock<IRegisterUserView>();
            _task = (IRegistrationTask) mocks.StrictMock<IRegistrationTask>();
    
          
           RegisterUserPresenter presenter = new RegisterUserPresenter(_view,_task);
            //Button btn = (Button)mocks.StrictMock(typeof (System.Web.UI.WebControls.Button));
              //Expect.Call(_view.RegisterButton).Return(btn);
            
                Expect.Call(_view.FirstName).Return("Stevan");
                Expect.Call(_view.LastName).Return("Thomas");
                Expect.Call(_view.Address).Return("Home");
                Expect.Call(_view.BillingAddress).Return("Home");
                Expect.Call(_view.Phone).Return("Phone");
                Expect.Call(() => _task.RegisterAccount(new Login(), new AccountDetail())).IgnoreArguments();
                Expect.Call(() => _task.RemoveAccount(new Login())).IgnoreArguments();
           
                Expect.Call(_view.Email).Return("stevan.thomas@hotmail.com");
              //Expect.Call(_view.RegisterResult).SetPropertyAndIgnoreArgument(); 
            
               
            
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