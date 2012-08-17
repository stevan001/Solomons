using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProdigyProducts.BLL.Domain
{
   public class Likedproduct
    {
       public int LikeID { get; set; }
       public string LikeBy { get; set; }
       public DateTime DateLiked { get; set; }
       public int? ProductID { get; set; }

    }
}
