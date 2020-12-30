using System;
using System.Collections.Generic;
using System.Linq;
using projetineo.Models;

namespace projetineo.Repositories
{
    public class TodoRepository : ITodoRepositorio
    {
        private TestContext _context;

        public void CreateTodo(Todo todo)
        {
            _context.Add(todo);
        }

        public IEnumerable<Todo> GetTodos()
        {
            Console.WriteLine(this._context.Todos.ToList());
            return this._context.Todos.ToList();
            
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
