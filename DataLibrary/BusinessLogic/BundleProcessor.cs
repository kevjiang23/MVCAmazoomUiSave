using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class BundleProcessor
    {
        public static int CreateBundle(int itemID, string itemName, int quantity)
        {
            BundleModel data = new BundleModel
            {
                ItemID = itemID,
                ItemName = itemName,
                Quantity = quantity
            };

            string sql = @"insert into dbo.Bundle (ItemID, ItemName, Quantity) 
                        values (@ItemID, @ItemName, @Quantity);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<BundleModel> LoadBundles()
        {
            string sql = @"select Id, ItemID, ItemName, Quantity
                        from dbo.Bundle;";
            return SqlDataAccess.LoadData<BundleModel>(sql);
        }
    }
}
