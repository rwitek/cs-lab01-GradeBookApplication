using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
                throw new InvalidCastException();

            if (averageGrade >= 80)
            {
                return 'A';
            }
            if (averageGrade < 80 && averageGrade >= 60)
            {
                return 'B';
            }
            if (averageGrade < 60 && averageGrade >= 40)
            {
                return 'C';
            }
            if (averageGrade < 40 && averageGrade >= 20)
            {
                return 'D';
            }
            else return 'F';
        }
    }
}
