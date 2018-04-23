using System.Web.Mvc;

namespace PopupControlAfterRequestMvc {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult OnLoad() {
            return View();
        }

        public ActionResult AfterJQueryAjax() {
            return View();
        }

        public ActionResult AfterSyncFormSubmit() {
            return View();
        }

        public ActionResult AfterAsyncAjaxFormSubmit() {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxAction() {
            return Content("After jQuery Ajax");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ActionMethodForSyncForm(string Description) {
            ViewData["showPopup"] = true;
            ViewData["content"] = Description;
            return View("AfterSyncFormSubmit");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ActionMethodForAsyncAjaxForm(string Description) {
            return Content(Description);
        }
    }
}