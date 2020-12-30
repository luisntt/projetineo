using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetineo.Models;
using projetineo.Repositories;

namespace projetineo.Controllers
{
    public class TodosController : Controller
    {

        private TodoRepository _todoRepository;

        public TodosController()
        {
            this._todoRepository = new TodoRepository();
        }
        
        
        // GET /todos
        public IActionResult Index()
        {
            var todos = from todo in _todoRepository.GetTodos() select todo;
            return View(todos);
        }
    }
    
}