using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExcepetion : ApplicationException
    {
        public NotFoundExcepetion(string message) : base(message) { }
    }
}
