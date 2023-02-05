using InterviewPrep.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace InterviewPrep.Web
{
    public static class Extentions
    {
        public static StatusCodeResult Result<T>(this QuestionController controller,T result) 
        {
            if(result == null)
            {
                return new NoContentResult();
            }
            return new OkResult();
        }

    }
}
