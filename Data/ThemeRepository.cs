using Data.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ThemeRepository:IThemeRepository
    {
        public void AddTheme(Theme theme) { }
        public void UpdateQuestion(Theme theme) { }
        public Theme GetThemeById(int id) { 
            throw new NotImplementedException();
        }
        public void DeleteThemeById(int id) { }
    }
}
