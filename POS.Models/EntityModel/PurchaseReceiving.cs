using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.EntityModel
{
    public class PurchaseReceiving
    {
        public int Id { get; set; }
        public int PurchaseNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Remarks { get; set; }
        public Double PurchaseTotalAmount { get; set; }

        
        
        //Branch Refered
        public int BranchId { get; set; }
        public Branch Branch { get; set; }


        //Supplier Refered
        public int? PartyId { get; set; }
        public Party Party { get; set; }

      

        //Employee Refered
        public int? EmployeeInfoId { get; set; }
        public  EmployeeInfo EmployeeInfo { get; set; }
        
        /// List OF Purchase Detais
        public virtual List<PurchaseReceivingDetails> PurchaseReceivingDetailses { get; set; }
   
        

    }
}
