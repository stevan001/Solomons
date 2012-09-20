using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class ProductDetailsPresenterTest
    {
        private Mock<IProductDetailsView> _view;
        private Mock<IProductDetailsTaks> _tasks;
        private ProductDetailsPresenter _presenter; 

        [SetUp]
        public void SetUp()
        {
            _view   = new Mock<IProductDetailsView>();
            _tasks = new Mock<IProductDetailsTaks>();
            _presenter = new ProductDetailsPresenter(_view.Object,_tasks.Object);
        }

        [Test]
        public void ShouldLoadProduct()
        {

        }

        [Test]
        public void ShouldCreateANewProduct()
        {

        }

        [Test]
        public void ShouldEditAProduct()
        {

        }

        [Test]
        public void ShouldDeleteSelectedProduct()
        {

        }

        [Test]
        public void ShouldReturnToProductListingPage()
        {

        }
    }
}