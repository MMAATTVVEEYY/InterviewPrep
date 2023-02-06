using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervewPrep.Core.Abstractions
{
    public interface IQuestionService
    {
        List<Theme> ProcessQuestions(List<Theme> questions);
        public IEnumerable<Question> GetAll();
        public void AddQuestion (Question question);
        public Task<Question?> DeleteQuestion(int id);
        public Task<Question?> GetQuestionById(int id);
        public Task<Question?> UpdateQuestion(Question updatedQuestion);
    }
}
