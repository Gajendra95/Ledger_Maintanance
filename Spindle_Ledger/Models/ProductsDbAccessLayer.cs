using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Spindle_Ledger.Models
{
    public class ProductsDbAccessLayer
    {
        SqlConnection con = new SqlConnection("Server = (localdb)\\mssqllocaldb; Database=Spindle_Ledger;Trusted_Connection=True;MultipleActiveResultSets=true");
        
        
        //Products Record
        public string AddProductsRecord(Products productEntities)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Products", con);
                //Seller
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ID", productEntities.ID);
                cmd.Parameters.AddWithValue("@Product_Name", productEntities.Product_Name);
                cmd.Parameters.AddWithValue("@Product_Description", productEntities.Product_Description);
                cmd.Parameters.AddWithValue("@Product_Cost", productEntities.Product_Cost);
                cmd.Parameters.AddWithValue("@Product_Quantity", productEntities.Product_Quantity);

                //Seller
                //cmd.Parameters.AddWithValue("@ID", productEntities.ID);
                cmd.Parameters.AddWithValue("@Seller_Name", productEntities.Seller_Name);
                cmd.Parameters.AddWithValue("@Seller_Address", productEntities.Seller_Address);
                cmd.Parameters.AddWithValue("@Seller_Contact", productEntities.Seller_Contact);


                //Customer
                cmd.Parameters.AddWithValue("@Customer_Name", productEntities.Customer_Name);
                cmd.Parameters.AddWithValue("@Customer_Address", productEntities.Customer_Address);
                cmd.Parameters.AddWithValue("@Customer_Contact", productEntities.Customer_Contact);


                //WareHouse
                cmd.Parameters.AddWithValue("@WareHouse_Name", productEntities.WareHouse_Name);
                cmd.Parameters.AddWithValue("@WareHouse_Address", productEntities.WareHouse_Address);
                cmd.Parameters.AddWithValue("@WareHouse_Cost", productEntities.WareHouse_Cost);
                cmd.Parameters.AddWithValue("@WareHouse_Contact", productEntities.WareHouse_Contact);


                //TransportFromSeller
                cmd.Parameters.AddWithValue("@TransportFromSeller_Name", productEntities.TransportFromSeller_Name);
                cmd.Parameters.AddWithValue("@TransportFromSeller_Description", productEntities.TransportFromSeller_Description);
                cmd.Parameters.AddWithValue("@TransportFromSeller_Cost", productEntities.TransportFromSeller_Cost);
                cmd.Parameters.AddWithValue("@TransportFromSeller_Contact", productEntities.TransportFromSeller_Contact);
                cmd.Parameters.AddWithValue("@TransportFromSeller_Date", productEntities.TransportFromSeller_Date);


                //TransportToCustomer
                //cmd.Parameters.AddWithValue("@ID", productEntities.ID);
                cmd.Parameters.AddWithValue("@TransportToCustomer_Name", productEntities.TransportToCustomer_Name);
                cmd.Parameters.AddWithValue("@TransportToCustomer_Description", productEntities.TransportToCustomer_Description);
                cmd.Parameters.AddWithValue("@TransportToCustomer_Cost", productEntities.TransportToCustomer_Cost);
                cmd.Parameters.AddWithValue("@TransportToCustomer_Contact", productEntities.TransportToCustomer_Contact);
                cmd.Parameters.AddWithValue("@TransportToCustomer_Date", productEntities.TransportToCustomer_Date);


                //cmd.Parameters.Clear();

                //cmd.Parameters.AddWithValue("@Department", productEntities.Department);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
    
}
