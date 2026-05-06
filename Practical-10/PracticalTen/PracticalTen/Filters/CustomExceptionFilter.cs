using System;
using System.Web.Mvc;

namespace PracticalTen.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                Exception ex = filterContext.Exception;
                var result = new ViewResult
                {
                    ViewName = "Error",
                    ViewData = new ViewDataDictionary()
                };
                if (ex is DivideByZeroException)
                {
                    result.ViewData["ErrorMessage"] = "Cannot divide by zero. Please enter a valid number.";
                }
                else
                {
                    result.ViewData["ErrorMessage"] = "An unexpected error occurred.";
                }
                filterContext.Result = result;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}