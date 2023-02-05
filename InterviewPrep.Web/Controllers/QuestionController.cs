using Entities.Entities;
using IntervewPrep.Core.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InterviewPrep.Web;

namespace InterviewPrep.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(questionService.GetAll());
        }

        [HttpGet("id")]
        public IActionResult GetQuestionById(int id)
        {
            return Ok(questionService.GetQuestionById(id));
        }

        [HttpPost]
        public IActionResult Post(Question question) 
        {
            questionService.AddQuestion(question);
            return Ok();
        }
        //Можно здесь логику иметь вобще???
        [HttpDelete]
        public async  Task<IActionResult> Delete(int id) 
        {
            var result = await questionService.DeleteQuestion(id);
            return this.Result(result);
        }
    }
}
