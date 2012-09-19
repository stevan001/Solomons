using System;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class AdminLoginPresenterTest
    {


        private Mock<IAdminLoginView> _view ;
        private Mock<IAdminLoginTasks> _tasks;
        private AdminLoginPresenter _presenter;
        
        [SetUp]
        public void Setup()
        {
             _view = new Mock<IAdminLoginView>();
            _tasks = new Mock<IAdminLoginTasks>();
            _presenter = new AdminLoginPresenter(_view.Object,_tasks.Object);
            _presenter.Initialize();
        }

        [Test]
        public void ShouldLoginAdminUser()
        {
            _view.SetupGet(v => v.Username).Returns("stevan.thomas@prodigyosft.net");
            _view.SetupGet(v => v.Password).Returns("testpass"); 
            _view.Raise(v=>v.LoginClick+=null,EventArgs.Empty);   
            _tasks.Verify(t=>t.Authenticate(_view.Object.Username,_view.Object.Password));
            
        }

        


        [Test]
        public void ShouldNotAllowNonAdminAccount()
        {
            _view.SetupGet(v => v.Username).Returns("stevan.thomas@prodigyosft.net");
            _view.SetupGet(v => v.Password).Returns("testpass");
            _view.Raise(v => v.LoginClick += null, EventArgs.Empty);
            _tasks.Verify(t => t.Authenticate(_view.Object.Username, _view.Object.Password));
        }

        [Test]
        public void ShouldInitatepasswordReset()
        {
            _view.SetupGet(v => v.Username).Returns("stevan.thomas@prodigyosft.net");
            
            _tasks.Setup(v => v.SendPasswordResetEmail(_view.Object.Username));
            _view.Raise(v => v.ForgotPassword += null, EventArgs.Empty);


            _view.VerifyGet(v=>v.Username);
            _tasks.Verify(v=>v.SendPasswordResetEmail(_view.Object.Username));
        }
    }
}