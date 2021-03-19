using CASHIR_SYSTEM.Areas.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASHIR_SYSTEM.Services
{
    class Actions
    {
        ApplicationDbContext context = new ApplicationDbContext();

        #region FoodCategory

        //GET ALL FoodCategory
        public List<FoodCategory> GetAllCat()
        {
            return context.FoodCategories.ToList();
        }

        //get all cat name
        public List<string> GetAllCatName()
        {
            return context.FoodCategories.Select(c=>c.CatName).ToList();
        }

        //GET Specific FoodCategory
        public string GetCat(int id)
        {
            return context.FoodCategories.FirstOrDefault(f => f.CatID == id).CatName;
        }

        //UPDATE FoodCategory
        public void UpdateCat(FoodCategory f)
        {
            FoodCategory f2 = context.FoodCategories.FirstOrDefault(c => c.CatID == f.CatID);
            f2.CatID = f.CatID;
            f2.CatName = f.CatName;
            context.SaveChanges();
        }

        //ADD FoodCategory
        public void AddCat(FoodCategory category)
        {
            context.FoodCategories.Add(category);
            context.SaveChanges();
        }

        //DELETE FoodCategory
        public void DeleteCat(int id)
        {
            FoodCategory f = context.FoodCategories.FirstOrDefault(e => e.CatID == id);
            context.FoodCategories.Remove(f);
            context.SaveChanges();
        }

        #endregion

        #region FoodItem

        //GET ALL items
        public List<FoodItems> GetAllFoodItems(int id)
        {
            var query =
                (from i in context.FoodItems
                 where i.CatId==id
                 select i).ToList();

            return query;
        }

        //get all item name
        public List<string> GetAllitemName()
        {
            return context.FoodItems.Select(c => c.ItemName).ToList();
        }

        //GET Specific item
        public FoodItems GetItem(int id)
        {
            return context.FoodItems.FirstOrDefault( i=> i.ItemID == id);
        }

        //ADD FoodItem
        public void AddItem(FoodItems item)
        {
            context.FoodItems.Add(item);
            context.SaveChanges();
        }

        //UPDATE FoodItem
        public void UpdateItem(FoodItems i)
        {
            FoodItems i2 = context.FoodItems.FirstOrDefault(c => c.ItemID== i.ItemID);
            i2.ItemID = i.ItemID;
            i2.ItemName = i.ItemName;
            i2.ItemPrice = i.ItemPrice;
            i2.CatId = i.CatId;
            i2.larg=i.larg;
            i2.small=i.small;
            i2.mid=i.mid;
            i2.largeprice=i.largeprice;
            i2.smallprice=i.smallprice;
            i2.midprice = i.midprice;

            context.SaveChanges();
        }

        //DELETE FoodItem
        public void DeleteItem(int id)
        {
            FoodItems i = context.FoodItems.FirstOrDefault(e => e.ItemID == id);
            context.FoodItems.Remove(i);
            context.SaveChanges();
        }

        #endregion


    }
}
