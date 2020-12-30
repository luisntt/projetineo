using System;
using System.Collections;
using System.Collections.Generic;
using projetineo.Models;

namespace projetineo.Repositories
{
    public interface ITodoRepositorio : IDisposable
    {
        void CreateTodo(Todo todo);
        IEnumerable<Todo> GetTodos();
    }
}