using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Views;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks; 
namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class ProductListingPresenterTest
    {
        private Mock<IProductListingView> _view;
        private Mock<IProductListingTasks> _task;
        private ProductListingPresenter _presenter; 

        [SetUp]
        public void Setup()
        {
            _view = new Mock<IProductListingView>();
            _task = new Mock<IProductListingTasks>();
            _presenter = new ProductListingPresenter(_view.Object,_task.Object);
        }

        [Test]
        public void ShouldGetListOfCategories()
        {
            var productCategories = new List<ProductCategory>();
            _task.Setup(t => t.GetCategories()).Returns(productCategories);

            _presenter.Load();
            _task.Verify(t => t.GetCategories());
            _view.VerifySet(v => v.ProductCategories = productCategories);
        }

        [Test] public void ShouldLoadSelectACategory()
        {
            _view.SetupGet(v => v.SelectedCategoryId).Returns(0);
            _view.Raise(v =>v.CategorySelectionChanged+=null,EventArgs.Empty);
            _view.VerifySet(v=>v.SelectedCategoryId);
            _task.Verify(t=>t.GetCategoryProducts(It.IsAny<int>()));

        }
        
        

        [Test]
        public void ShouldSelectAProduct()
        {
            
            
            _view.Raise(v=>v.Select += null,EventArgs.Empty);

        }

        [Test]
        public void ShouldRemoveAProduct()
        {

        }
    }
}