using Moq;
using NUnit.Framework;
using ProdigyProducts.BLL.Presenters;
using ProdigyProducts.BLL.Tasks;
using ProdigyProducts.BLL.Views;

namespace ProdigyProducts.Test.PresenterTests
{
    [TestFixture]
    public class ProductDetailsPresenterTest
    {
        private Mock<IProductDetailsView> _view;
        private Mock<IProductDetailsTasks> _tasks;
        private ProductDetailPresenter _presenter; 

        [SetUp]
        public void SetUp()
        {
            _view   = new Mock<IProductDetailsView>();
            _tasks = new Mock<IProductDetailsTasks>();
            _presenter = new ProductDetailPresenter(_view.Object,_tasks.Object);
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