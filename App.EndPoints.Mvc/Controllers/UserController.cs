using App.Domain.Core.Contracts.AppService;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.Mvc.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public IActionResult Index()
        {
            var usersToInspect = _userAppService.ViewAllUsers();
            return View(usersToInspect);
        }


        public IActionResult Detail(int id)
        {
            var user = _userAppService.DisplayUserInfo(id);
            return View(user);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User newUser)
        {
            _userAppService.CreateNewUser(newUser);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string searchString)
        {
            var users = _userAppService.ViewAllUsers();
            if (!String.IsNullOrEmpty(searchString))
            {
                var filteredUsers = users.Where(u => u.FirstName.ToLower().Contains(searchString.ToLower())
                || u.LastName.ToLower().Contains(searchString.ToLower()));
                return View("Index",filteredUsers);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var userToEdit = _userAppService.DisplayUserInfo(id);
            return View(userToEdit);
        }

        [HttpPost]
        public IActionResult Edit(User editedUser) 
        {
            _userAppService.EditUserInfo(editedUser.Id, editedUser);
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            var userToDelete = _userAppService.DisplayUserInfo(id);
            return View(userToDelete);
        }

        [HttpPost]
        public  IActionResult ConfirmDeletion(int id)
        {
            _userAppService.DeleteUser(id);
            return RedirectToAction("Index");
        }

    }
}
