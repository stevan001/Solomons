using System;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.BLL.Presenters
{
    public class CompleteRegPresenter
    {
        private ICompleteRegView _view;
        private IRegistrationTask _tasks; 
        public CompleteRegPresenter(ICompleteRegView view): this (view,new RegistrationTask())
        {
            
        }

        
        public CompleteRegPresenter(ICompleteRegView view, IRegistrationTask tasks)
        {
            _view = view;
            _tasks = tasks;
        } 
        public void Initialize()
        {
            _view.CompleteRegistrationClick += new System.EventHandler(CompleteRegistrationClick);
        }

        void CompleteRegistrationClick(object sender, System.EventArgs e)
        {
            try
            {
                _tasks.CompleteRegistration(_view.RegistrationCode);
                _view.ProcedeToLogin = true; 
                _view.RegistationResult = "Welcome to Solomons. Click the button below To Login";
            }
            catch (Exception exception)
            {
                _view.ProcedeToLogin = false;
                _view.RegistationResult = "Sorry there was a problem with completing your registration"; 
            }
        }
    }
}