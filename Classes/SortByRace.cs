using System.Collections;
using System.Collections.Generic;

namespace Character_Builder.Classes
{
    class SortByRace : IComparer<Character>
    {
        public int Compare(Character x, Character y)
        {
            return x.race.raceName.CompareTo(y.race.raceName);
        }
    }
}
