using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExa.Models;

namespace WebApiExa.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Producttb> Get()
        {
            using (ProductModel db = new ProductModel())
            {
                return db.Producttbs.ToList();
            }
        }
        public Producttb Get(int id)
        {
            using (ProductModel db = new ProductModel())
            {
                return db.Producttbs.Where(x=>x.ProductId==id).FirstOrDefault();
            }
        }
        public HttpResponseMessage Post([FromBody] Producttb product)
        {
            using (ProductModel db = new ProductModel())
            {
                try
                {
                    db.Producttbs.Add(product);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, product);
                    message.Headers.Location = new Uri(Request.RequestUri + product.ProductId.ToString());
                    return message;
                }
                catch(Exception ex)
                {
                   return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
        }
        public void Delete(int id)
        {
            using (ProductModel db = new ProductModel())
            {
                db.Producttbs.Remove(db.Producttbs.Where(x => x.ProductId == id).FirstOrDefault());
                db.SaveChanges();
            }
        }
        public void Put(int id,[FromBody] Producttb product)
        {
            using (ProductModel db = new ProductModel())
            {
               var y= db.Producttbs.Where(x => x.ProductId == id).FirstOrDefault();
                y.ProductId = product.ProductId;
                y.productName = product.productName;
                db.SaveChanges();
            }
        }
    }
}
