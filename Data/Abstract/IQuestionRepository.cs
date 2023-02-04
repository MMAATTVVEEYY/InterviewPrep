using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        void AddQuestion(Question question);
        void UpdateQuestion(Question question);
        Task<Question> GetQuestionById(int id);
        void DeleteQuestionById(int id);
    }
}
