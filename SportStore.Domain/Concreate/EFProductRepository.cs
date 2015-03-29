using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entities;
using SportStore.Domain.Concreate;
using SportStore.Domain.Abstract;
namespace SportStore.Domain.Concreate
{
   public class EFProductRepository : IProductsRepository{
       private EFDbContext context = new EFDbContext();
       public IEnumerable<Product> Products{
           get{return context.Products;}
       }
   }
}
