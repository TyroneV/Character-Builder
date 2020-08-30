
using System.Collections.Generic;

namespace Character_Builder.Classes
{
    class SortByGender : IComparer<Character>
    {

        public int Compare(Character x, Character y)
        {
            return x.gender.CompareTo(y.gender);
        }
    }
}
