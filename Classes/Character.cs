using Character_Builder.Classes;
using System;
using System.Text.Json.Serialization;

namespace Character_Builder
{
    public class Character : IComparable<Character>
    {
        [JsonPropertyName("character_name")]
        public string name { get; set; }
        [JsonPropertyName("gender")]
        public string gender { get; set; }
        [JsonPropertyName("job")]
        public Job job { get; set; }
        [JsonPropertyName("race")]
        public Race race { get;set; }

        public Character()
        {

        }
        public Character(string name, string gender, Job job, Race race)
        {
            this.name = name;
            this.gender = gender;
            this.job = job;
            this.race = race;
        }

        public int CompareTo(Character other)
        {
            return name.CompareTo(other.name);
        }
    }
}
