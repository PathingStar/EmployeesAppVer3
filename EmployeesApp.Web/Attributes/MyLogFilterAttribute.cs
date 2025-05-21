using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.Attributes
{
    public class MyLogFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action is about be executed");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action now has been excuted");
        }
    }
}
