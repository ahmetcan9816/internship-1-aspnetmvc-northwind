using System.Web.Mvc;
using Northwind.Entities;
using Northwind.Interfaces;

namespace Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);
            cart.AddToCart(product,1);
            return RedirectToAction("Index",cart);

        }

        public ViewResult Index(Cart cart)
        {
            return View(cart);
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);
            cart.RemoveFromCart(product);
            return RedirectToAction("Index",cart);

        }

        [HttpGet]
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult CheckOut(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                //Managerden veri tabanına bağlantı sağlanacak.
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

        public PartialViewResult CartSummary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}