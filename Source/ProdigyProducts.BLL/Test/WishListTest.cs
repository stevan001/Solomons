using System;
using NUnit.Framework;
using ProdigyProducts.BLL.Domain;
using ProdigyProducts.BLL.Services;

namespace ProdigyProducts.BLL.Test
{


    [TestFixture]
    public class WishListTest
    {
         [Test]
        public void ShouldGetAListofwishlists()
         {
             

             WishListService wishListService = new WishListService();
             var items = wishListService.GetAllWishLists(); 

             Assert.AreEqual(items.Count,0);
             Console.WriteLine(items.Count.ToString());



         }
    }
}