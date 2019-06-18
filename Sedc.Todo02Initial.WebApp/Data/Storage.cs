using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Sedc.Todo02Initial.WebApp.Models;

namespace Sedc.Todo02Initial.WebApp.Data
{
    public class Storage
    {
        private static readonly List<Todo> _todoList;

        static Storage()
        {
            _todoList = new List<Todo>();
        }

        public List<Todo> GetAll(Expression<Func<Todo, bool>> filter = null)
        {
            return _todoList.Where(x => filter == null || filter.Compile()(x)).ToList();
        }

        public void Save(Todo todo)
        {
            if (_todoList.Any(x => x.Title == todo.Title))
                _todoList[_todoList.FindIndex(x => x.Title == todo.Title)] = todo;
            else
                _todoList.Add(todo);
        }

        public void Delete(Todo todo)
        {
            if (_todoList.Any(x => x.Title == todo.Title))
                _todoList.RemoveAt(_todoList.FindIndex(x => x.Title == todo.Title));
        }
    }
}
