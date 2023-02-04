using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IThemeRepository
    {
        void AddTheme(Theme theme);
        void UpdateQuestion(Theme theme);
        Theme GetThemeById(int id);
        void DeleteThemeById(int id);
    }
}
