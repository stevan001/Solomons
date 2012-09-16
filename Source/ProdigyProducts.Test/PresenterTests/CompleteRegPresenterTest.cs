using System;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class CompleteRegPresenterTest
    {

        private CompleteRegPresenter _presenter;
        private Mock<ICompleteRegView> _view;
        private Mock<IRegistrationTask> _tasks; 
        [SetUp]
        public void Setup()
        {
            _view = new Mock<ICompleteRegView>();
            _tasks = new Mock<IRegistrationTask>();
            _presenter = new CompleteRegPresenter(_view.Object, _tasks.Object); 
            _presenter.Initialize();
        }
         
        [Test]
        public void ShouldCompleteRegistration()
        {
            _view.SetupGet(v => v.RegistrationCode).Returns("regcode");
            _view.Raise(v=>v.CompleteRegistrationClick+=null,EventArgs.Empty);
            _tasks.Verify(t => t.CompleteRegistration("regcode")); 
        }

        [Test]
        public void ShouldDisplayProceedToLogin()
        {
            _view.SetupGet(v => v.RegistrationCode).Returns("regcode");
            _view.Raise(v => v.CompleteRegistrationClick += null, EventArgs.Empty);
            _tasks.Verify(t => t.CompleteRegistration("regcode")); 
            _view.VerifyGet(v=>v.RegistrationCode);
            _view.VerifySet(v=>v.ProcedeToLogin = true);
        }

        [Test]
        public void ShouldDisplayCompletionResult()
        {
            _view.SetupGet(v => v.RegistrationCode).Returns("regcode");
            _view.Raise(v => v.CompleteRegistrationClick += null, EventArgs.Empty);
            _tasks.Verify(t => t.CompleteRegistration("regcode"));
            _view.VerifySet(v => v.RegistationResult = It.IsAny<string>());
        }
        [Test]
        public void ShouldNotProceedToShowLogin()
        {
            _view.SetupGet(v => v.RegistrationCode).Returns("regcode");
            _tasks.Setup(t => t.CompleteRegistration("regcode")).Throws<ApplicationException>();
            _view.Raise(v => v.CompleteRegistrationClick += null, EventArgs.Empty);
            _tasks.Verify(t => t.CompleteRegistration("regcode"));
            _view.VerifySet(v => v.ProcedeToLogin = false);
        }
    }
}