using challenger.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace challenger.Data
{
    public class ProductAdmin
    {


        public IEnumerable<Product> GetData()
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {
                return context.Product.AsNoTracking().ToList();

            }
        }



        public Product GetData(int id)
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {
                return context.Product.FirstOrDefault(v => v.ProductID == id);


            }
        }


        public void SaveData(Product modelo)
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {
                context.Product.Add(modelo);
                context.SaveChanges();
            }


        }

     

        public void UpdateProduct(Product modelo)
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {
                context.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();


            }
      
        }
        public void Delete(Product modelo)
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {
                context.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();


            }

        }


    }
}