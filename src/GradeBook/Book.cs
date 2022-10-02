
namespace GradeBook
{
    public class Book
    {
        public List<int> die;
        public Book()
        {
            die = new List<int>();
        }
        public int AddGrade(int d, int b)
        {
            die.Add(d + b);
            return die[0];
        }
    }
}

