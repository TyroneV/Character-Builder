using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Builder.Classes
{
    class SortByJob : IComparer<Character>
    {
        public int Compare(Character x, Character y)
        {
            return x.job.jobName.CompareTo(y.job.jobName);
        }
    }
}
