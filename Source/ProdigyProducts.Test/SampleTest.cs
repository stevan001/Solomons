using NUnit.Framework;
using ProdigyProducts.BLL.Adapters;
using ProdigyProducts.BLL.Domain;

namespace ProdigyProducts.Test
{
    [TestFixture]
    public class SampleTest
    {
         [Test]
        public void ShouldRunATest()
         {
             Assert.AreEqual(1,1+0);
         }

        [Test]
        public void ShouldCreateAWishListForTheDatabase()
        {
            WishList wl  = new WishList();
            wl.AccountID = 1;
            wl.ListName = " My Christmas WishList ";
            wl.WishListID = 0; 
            WishListAdapter adapter = new WishListAdapter();
            ProdigyProducts.BLL.Data.WishList dataWl = adapter.ConvertToDataObject(wl); 
            Assert.AreEqual(wl.AccountID,dataWl.account_id);
            Assert.AreEqual(wl.ListName,dataWl.list_name);
            Assert.AreEqual(wl.WishListID,dataWl.wish_list_id);


        }
        [Test]
        public void ShouldChangeAccountOnWishList()
        {
            WishList l = new WishList();
            l.AccountID = 1;
            l.ListName = " My Christmas WishList ";
            l.WishListID = 0;
            WishListAdapter adapter = new WishListAdapter();
            ProdigyProducts.BLL.Data.WishList dataWl = adapter.ConvertToDataObject(l);
            l.AccountID = 1; 

            
            adapter.UpdateDataObject(l,ref dataWl);
            Assert.AreEqual(l.AccountID, dataWl.account_id);
        }
    }
}