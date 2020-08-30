using Character_Builder.Interface;
using System;
using System.Text.Json.Serialization;

namespace Character_Builder.Classes
{
    public class Race :  IRace, IComparable
    {
        [JsonPropertyName("raceName")]
        public string raceName { get; set; }
        [JsonPropertyName("raceTrait")]
        public string raceTrait { get; set; }
        public Race()
        {
        }

        public Race(string raceName)
        {
            this.raceName = raceName;
        }

        public Race(string raceName, string raceTrait)
        {
            this.raceName = raceName;
            this.raceTrait = raceTrait;
        }

        public void uniqueTrait()
        {
            Console.WriteLine($"{raceName} has {raceTrait}");
        }

        public int CompareTo(object obj)
        {
            int i = 0;
            Race r = obj as Race;
            if (r != null)
            {
                i = string.Compare(raceName, r.raceName);
            }
            return i;
        }

        public override string ToString()
        {
            return $"{raceName} has {raceTrait}";
        }
    }
}
