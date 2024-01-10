using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Coure_API_Assesment.Models;
using System.Linq;
using Coure_API_Assesment.Helpers.StringExtensions;

namespace Coure_API_Assesment.Helpers.ValidationFilter
{
    public class ValidationActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ObjectResult(new FilterResponse()
                {
                    ResponseCode = "03",
                    ResponseMessage = context.ModelState.Where(x => x.Value.Errors.Count > 0).ToDictionary(kvp => kvp.Key, kvp => string.Join(", ", kvp.Value.Errors.Select(e => e.ErrorMessage))).ToDictionaryString(),
                })
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
            //base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
    }
}
