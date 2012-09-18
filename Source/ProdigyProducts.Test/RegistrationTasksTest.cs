using System;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;
using ProdigyProducts.BLL.Tasks;

namespace ProdigyProducts.Test
{
    [TestFixture]
    public class RegistrationTasksTest
    {
        private Mock<ILoginService> _loginService;
        private Mock<IAccountDetailService> _accountDetailService;
        private IRegistrationTask _registrationTask;
        private Mock<ILogin> _login;
        private Mock<IAccountDetail> _accountDetail; 
        
        [SetUp]
        public void SetupTests()
        {
            _loginService = new Mock<ILoginService>();
            _accountDetailService = new Mock<IAccountDetailService>();
            _registrationTask = new RegistrationTask(_loginService.Object,_accountDetailService.Object);

            _login = new Mock<ILogin>();
            _accountDetail = new Mock<IAccountDetail>();

            _login.SetupProperty(l=> l.Email , "stevan.thomas@prodigysoft.net");
            _login.SetupProperty(l=> l.Password , "Testpass");
            _login.SetupProperty(l=> l.Registered , false);
            _login.SetupProperty(l=> l.RegistrationCode , "regcode");


            _accountDetail.SetupProperty(a => a.FirstName, "Stevan"); 
            _accountDetail.SetupProperty(a => a.LastName, "Thomas"); 
            _accountDetail.SetupProperty(a => a.PhoneNumber, "332-9815"); 
            _accountDetail.SetupProperty(a => a.Email, "stevan.thomas@prodigysoft.net"); 
            _accountDetail.SetupProperty(a => a.Address, "home"); 
            _accountDetail.SetupProperty(a => a.BillingAddress, "home"); 

        }

        [Test]
        public void Should_create_personlized_email()
        {
            _registrationTask.LoginAccount = _login.Object;
            _registrationTask.AccountDetails = _accountDetail.Object;
            string email = _registrationTask.GenerateEmail(); 
            Assert.IsNotNullOrEmpty(email);
            _login.VerifyGet(x=>x.Email,Times.AtMostOnce());Assert.Greater(email.IndexOf("Stevan"),-1);
        }
        [Test]
        public void ShouldCreateAccount()
        {
            _registrationTask.LoginAccount = _login.Object;
            _registrationTask.AccountDetails = _accountDetail.Object;
            _loginService.Setup(x => x.Insert(_login.Object));
            _loginService.Setup(x => x.GenerateRegistrationCode()).Returns(Guid.NewGuid().ToString);
            _accountDetailService.Setup(a => a.Insert(_accountDetail.Object));
            _registrationTask.RegisterAccount();
            _loginService.Verify(x=>x.GenerateRegistrationCode(),Times.AtLeastOnce());
            
        }

        [Test]
        public void ShouldNotAttemptToRegisterAnAccountTwice()
        { 
            
            _login.SetupGet(x => x.Registered).Returns(true);
            _registrationTask.LoginAccount = _login.Object;
            _loginService.Setup(x => x.Register("regcode")).Throws<ApplicationException>();

            try
            {
                _registrationTask.CompleteRegistration("regcode");
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e);
            }
            _loginService.Verify(x=>x.Register("regcode"));
           
        }
        [Test]
        public void ShouldRegisterAccount()
        {
           //we should get the account via the code and then process the registration 
           _loginService.Setup(x => x.Register("regcode")); 
           _registrationTask.CompleteRegistration("regcode");
        }

      

       

        

    }
}