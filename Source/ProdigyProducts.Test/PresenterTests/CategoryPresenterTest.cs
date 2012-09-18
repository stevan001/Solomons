using System.Collections.Generic;
using System.Web.UI.WebControls;
using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Data;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Views;
using ProdigyProducts.BLL.Tasks;
using ProductCategory = ProdigyProducts.BLL.Domain.ProductCategory;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class CategoryPresenterTest
    {
        private Mock<IAdminProductCategoryView> _view;
        private Mock<IAdminProductCategoryTasks> _tasks;
        private AdminCategoryPresenter _presenter; 


        [SetUp]
        public void Setup()
        {
            _tasks = new Mock<IAdminProductCategoryTasks>();
            _view = new Mock<IAdminProductCategoryView>();
            _presenter = new AdminCategoryPresenter(_view.Object, _tasks.Object);
            _presenter.Initalize();
        }

        [Test]
        public void ShouldGetListofCategories()
        {
            var productCategories = new List<ProductCategory>();
            _tasks.Setup(v => v.LoadCategories()).Returns(productCategories);
            _presenter.LoadCategories(); 
            _tasks.Verify(v=>v.LoadCategories());
            _view.VerifySet(v=>v.Categories = productCategories);

        }
        [Test]
        public void ShouldGetSelectACateogry()
        {
            _tasks.Setup(t => t.LoadCategory(It.IsAny<int>())).Returns(new ProductCategory());
            _view.Raise(v=>v.Edit+=null,System.EventArgs.Empty);
            _tasks.Verify(t=>t.SaveCategory(It.IsAny<ProductCategory>()));
            _view.VerifySet(v=>v.Category = It.IsAny<ProductCategory>());
        }

        [Test]
        public void ShouldSaveTheCategory()
        {
            _tasks.Setup(t => t.LoadCategory(It.IsAny<int>())).Returns(new ProductCategory());
            _view.Raise(v=>v.Edit+=null,System.EventArgs.Empty);
            _view.VerifySet(v=>v.EditResult = It.IsAny<string>());
        }
    }
}