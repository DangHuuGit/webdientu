using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbandodientu_html.Context;
using webbandodientu_html.Models;


namespace webbandodientu_html.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        OnlineShopEntitiess objModel = new OnlineShopEntitiess();
        public ActionResult Index(int Id)
        {
            // lấy thông tin sản phầm theo id truyền vào
            var objProduct = objModel.Products.Where(n =>n.Id == Id).FirstOrDefault();


            // lấy danh sách danh mục
            var lstCategory = objModel.Categories.ToList();
            //lấy danh sách sản phầm liên quan trong categoryId dược lấy từ biến objproduct
            var lstProduct = objModel.Products.Where(n => n.CategoryId == objProduct.CategoryId).ToList();

            ProductDetailModel objproductDetailModel = new ProductDetailModel();
            objproductDetailModel.objProduct = objProduct;
            objproductDetailModel.ListCategory = lstCategory; 
            objproductDetailModel.ListProduct = lstProduct;

            return View(objproductDetailModel);
        }
    }
}