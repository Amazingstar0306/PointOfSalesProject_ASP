using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{ 
   public class PurchaseReceivingDetails
    {
        public int Id { get; set; }
        [Display(Name ="Price")]
        public double PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public double PurchaseItemTotalPrice { get; set; }

        public int? PurchaseReceivingId { get; set; }
        public PurchaseReceiving PurchaseReceiving { get; set; }

        public int ItemId{ get; set; }
        public Item Item { get; set; }

    }
}
