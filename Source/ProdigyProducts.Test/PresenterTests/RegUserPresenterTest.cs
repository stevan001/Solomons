using System;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class RegUserPresenterTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            _view = new Mock<IRegisterUserView>();
            _task = new Mock<IRegistrationTask>();
            _presenter = new RegisterUserPresenter(_view.Object, _task.Object);
            _presenter.Initailize();
        }

        [TearDown]
        public void TearDown()
        {
        }

        #endregion

        private Mock<IRegisterUserView> _view;
        private Mock<IRegistrationTask> _task;
        private RegisterUserPresenter _presenter;
   

        /// <summary>
        /// This test should make sure everything is gotten from the veiw also we wanted to test that the event is raised and nthe register method is called 
        /// </summary>
        [Test]
        public void ShouldCreateANewUser()
        {
            
            _task.Setup(x => x.RegisterAccount(It.IsAny<Login>(), It.IsAny<AccountDetail>()));
            _view.Raise(m => m.RegisterEvent += null, EventArgs.Empty);
            _view.VerifyGet(v => v.FirstName);
            _view.VerifyGet(v => v.LastName);
            _view.VerifyGet(v => v.Phone);
            _view.VerifyGet(v => v.Email);
            _view.VerifyGet(v => v.Address);
            _view.VerifyGet(v => v.BillingAddress);
            _view.VerifyGet(v => v.Password);
            _task.Verify(x => x.RegisterAccount(It.IsAny<Login>(), It.IsAny<AccountDetail>()));
        }

        [Test]
        public void ShouldDisplayErrorMessage()
        {
            
            _task.Setup(x => x.RegisterAccount(It.IsAny<Login>(), It.IsAny<AccountDetail>())).Throws(new ApplicationException("error in registration"));
            _view.Raise(m => m.RegisterEvent += null, EventArgs.Empty);
            _task.Verify(x=>x.RemoveAccount(It.IsAny<Login>()));
          
        }

        [Test]
        public void ShouldDisplayRegistrationMessage()
        {
            _view.Raise(v=>v.RegisterEvent+=null,EventArgs.Empty);
            _view.VerifySet(v => v.RegisterResult = It.IsAny<string>());
        }
    }
}