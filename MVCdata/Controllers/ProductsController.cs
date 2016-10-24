using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdata.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        // GET: Products
        [Route("{category}/{id}")]
        public string Index(string category,string id)
        {
            if (!string.IsNullOrEmpty(category))
            {
                if (!string.IsNullOrEmpty(id))
                {
                    return "Product Category is:" + category + "price :" + id;
                }
                else
                {
                    return "product category is :" + category;
                }
            }
            return "This is all the product";

        }
        [Route("~/name")]
        public string name()
        {
            return "Hi are you Antony";
        }
        [Route("~/for-sale/{id?}")]
        public string forsale(string id)
        {
            return "These Products for Sale" + id;
        }
    }
}