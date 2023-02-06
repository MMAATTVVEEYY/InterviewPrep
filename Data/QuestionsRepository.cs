using Data;
using Data.Abstract;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//тут вобще должен быть доступ к данным
namespace InterviewPrep.Data
{
    public class QuestionsRepository:IQuestionRepository
    {
        private readonly InterviewPrepDbContext _context;
        public QuestionsRepository(InterviewPrepDbContext interviewPrepDbContext)
        {
            this._context = interviewPrepDbContext;
        }

        public async Task<Question> GetQuestionById(int id) {
           var question = await _context.Questions.AsNoTracking().FirstOrDefaultAsync(q => q.QuestionId == id);
           return question;
        }
        public void AddQuestion(Question question) 
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
        }
       public async Task<Question?> UpdateQuestion(Question question)
        {
            var questionToUpdate = await _context.Questions.FirstOrDefaultAsync(q => q.QuestionId == question.QuestionId);
            if (questionToUpdate != null)
             {
                 questionToUpdate.AnswerText =      question.AnswerText;
                 questionToUpdate.QuestionText =    question.QuestionText;
                 questionToUpdate.ImagePath =       question.ImagePath;
                await _context.SaveChangesAsync();
            }
            return questionToUpdate;
        }

        public async void DeleteQuestionById(int id)
        {
            var question = await _context.Questions.FirstOrDefaultAsync(q => q.QuestionId == id);
            _context.Remove(question);
            _context.SaveChanges();
        }

        public IEnumerable<Question> GetAll()
        {

            var questions = _context.Questions;
            return questions;
        }
    }
}
