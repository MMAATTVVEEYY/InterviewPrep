using InterviewPrep.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPrep.Web
{
    public static class Extentions
    {
        public static ObjectResult Result<T>(this QuestionController controller,T result) 
        {
            if(result == null)
            {
                return new NotFoundObjectResult(result);
            }
            return new OkObjectResult(result);
        }

    }
}
