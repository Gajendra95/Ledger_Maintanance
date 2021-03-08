using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spindle_Ledger.Models
{

    //Products
    public class Products
    {


        //public DateTime date{ get; set; }

        //Products
        [Required]
        public string ID { get; set; }
        [Required]
        public string Product_Name { get; set; }
        //[Required]
        public string Product_Description { get; set; }
        [Required]
        public string Product_Cost { get; set; }
        [Required]
        public string Product_Quantity { get; set; }




        //Seller
        [Required]
        public string Seller_Name { get; set; }
        [Required]
        public string Seller_Address { get; set; }
        [Required]
        public string Seller_Contact { get; set; }



        //TransferFromSeller
        [Required]
        public string TransportFromSeller_Name { get; set; }
        //[Required]
        public string TransportFromSeller_Description { get; set; }
        [Required]
        public string TransportFromSeller_Cost { get; set; }
        [Required]
        public string TransportFromSeller_Contact { get; set; }
        [Required]
        public DateTime TransportFromSeller_Date { get; set; }




        //WareHouse
        [Required]
        public string WareHouse_Name { get; set; }
        [Required]
        public string WareHouse_Address { get; set; }
        [Required]
        public string WareHouse_Cost { get; set; }
        [Required]
        public string WareHouse_Contact { get; set; }


        


        //TransportToCustomer
        [Required]
        public string TransportToCustomer_Name { get; set; }
        //[Required]
        public string TransportToCustomer_Description { get; set; }
        [Required]
        public string TransportToCustomer_Cost { get; set; }
        [Required]
        public string TransportToCustomer_Contact { get; set; }
        [Required]
        public DateTime TransportToCustomer_Date { get; set; }



        //Customer
        [Required]
        public string Customer_Name { get; set; }
        [Required]
        public string Customer_Address { get; set; }
        [Required]
        public string Customer_Contact { get; set; }



    }

    
}
