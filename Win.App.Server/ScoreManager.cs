using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class ScoreManager
    {


        private QuizBeeEntities _context;
        public QuizBeeEntities Context
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
        /// This wil update score of hte contestant on the database,
        /// The default value that will be addes is 1, unless specified
        /// </summary>
        /// <param name="contestName">Name of the contest.</param>
        /// <param name="pointsAdded">The points added.</param>
        public void UpdateScore(string contestName, int pointsAdded = 1)
        {
            //look for the user
            

        }

    }
}
