using System.Collections.Generic;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class QuestionManager
    {


        private QuizBeeEntities _context;
        private QuizBeeEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new QuizBeeEntities();
                }

                return _context;
            }
            set { _context = value; }
        }


        /// <summary>
        /// Gets the quizes by difficulty.
        /// </summary>
        /// <param name="difficultyLevel">The difficulty level.</param>
        /// <returns></returns>
        public List<Quiz> GetQuizesByDifficulty(int difficultyLevel)
        {
            return Context.Quizes.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }





    }
}