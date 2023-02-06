using IntervewPrep.Core.Abstractions;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace IntervewPrep.Core
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;
        public QuestionService(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public async void AddQuestion(Question question)
        {
            Question Collisionquestion = await questionRepository.GetQuestionById(question.QuestionId);
            if (Collisionquestion == null)
            {
                questionRepository.AddQuestion(question);
            }
            
            
        }
        
        public async Task<Question?> DeleteQuestion(int id)
        {  
            Question question = await questionRepository.GetQuestionById(id);
            if (question != null) 
            {
                questionRepository.DeleteQuestionById(id);
                //return false;// удалено, все ок
            }
            
            //return true; //не удалено, ничего и не было найдено
            return question;
            //
           
        }

        public IEnumerable<Question> GetAll()
        {
            return questionRepository.GetAll();
           
        }

        public async Task<Question?> GetQuestionById(int id)
        {
           
            var question = await questionRepository.GetQuestionById(id);
            return question;
        }

        public List<Theme> ProcessQuestions(List<Theme> questions)
        {

            throw new NotImplementedException();
        }

        public async Task<Question?> UpdateQuestion(Question UpdatedQuestion)
        {
            //var question = await questionRepository.GetQuestionById(id);
            if (UpdatedQuestion == null)
            {
                return null;
            }
            var result = await questionRepository.UpdateQuestion(UpdatedQuestion);
           
            
            return result;
            
        }
    }
}
