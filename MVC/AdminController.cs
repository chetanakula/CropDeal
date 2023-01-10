using CropsMVC.Models;
using CropsMVC.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CropsMVC.Controllers
{
    public class AdminController : Controller
    {
        public async Task<ActionResult> Admin(AdminViewModel adminViewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    AdminViewModel newUser = new AdminViewModel();
                    var service = new ServiceRepository();
                    {
                        using (var response = service.VerifyLogin("Admin", adminViewModel))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            newUser = JsonConvert.DeserializeObject<AdminViewModel>(apiResponse);
                        }
                    }
                    if (newUser != null)
                    {
                        ViewBag.message = "Login Success";
                        return RedirectToAction("Admin", "Admin");
                    }
                    else
                    {
                        ViewBag.message = "incorrect";


                    }
                }
            }
            catch
            {


            }

            return View(adminViewModel);

        }
    }
}