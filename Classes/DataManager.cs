
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Character_Builder.Classes
{
    class DataManager
    {
        private static Dictionary<string, Character> characters 
            = new Dictionary<string, Character>();

        private static HashSet<string> genders = new HashSet<string>();

        private static Dictionary<string,Job> jobs
            = new Dictionary<string, Job>();

        private static Dictionary<string, Race> races 
            = new Dictionary<string, Race>();


        public static Dictionary<string, Character> GetCharacters()
        {
            return characters;
        }
        public static HashSet<string> GetGenders()
        {
            return genders;
        }
        public static Dictionary<string,Job> GetJobs()
        {
            return jobs;
        }

        public static Dictionary<string,Race> GetRaces()
        {
            return races;
        }
        public static List<string> ListCharacters()
        {
            
            return characters.Keys.ToList();
        }
        public static List<string> ListGenders()
        {
            return genders.ToList();
        }
        public static List<string> ListJobs()
        {
            return jobs.Keys.ToList();
        }

        public static List<string> ListRaces()
        {
            return races.Keys.ToList();
        }

        public static async Task<bool> AddCharacter(Character character)
        {
            bool added = false;
            if (!characters.ContainsKey(character.name))
            {
                characters.Add(character.name, character);
                await SaveCharacters();
                added = true;
            }
            return added;
        }
        public static async Task<bool> AddGender(string gender)
        {
            bool added = false;
            if (!genders.Contains(gender))
            {
                genders.Add(gender);
                await SaveGender();
                added = true;
            }
            return added;
        }
        public static async Task<bool> AddRace(Race race)
        {
            bool added = false;
            if (!races.ContainsKey(race.raceName))
            {
                races.Add(race.raceName, race);
                await SaveRaces();
                added = true;
            }
            return added;
        }

        public static async Task<bool> AddJob(Job job)
        {
            bool added = false;
            if (!jobs.ContainsKey(job.jobName))
            {
                jobs.Add(job.jobName, job);
                await SaveJobs();
                added = true;
            }
            return added;
        }

        public static async Task SaveFiles()
        {
            await Save(characters);
            await Save(genders);
            await Save(jobs);
            await Save(races);
        }

        public static async Task SaveCharacters()
        {
            await Save(characters);
        }

        public static async Task SaveGender()
        {
            await Save(genders);
        }
        public static async Task SaveJobs()
        {
            await Save(jobs);
        }
        public static async Task SaveRaces()
        {
            await Save(races);
        }
        public static async Task Save(Dictionary<string, Character> character)
        {
            string filePath =
                $@"{AppDomain.CurrentDomain.BaseDirectory}\character";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath += @"\characters.json";

            using (FileStream fs = File.Create(filePath))
            {
                await JsonSerializer.SerializeAsync(fs, character);
            }
        }

        public static async Task Save(Dictionary<string, Race> race)
        {
            string filePath =
                $@"{AppDomain.CurrentDomain.BaseDirectory}\character";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath += @"\races.json";

            using (FileStream fs = File.Create(filePath))
            {
                await JsonSerializer.SerializeAsync(fs, race);
            }
        }
        public static async Task Save(Dictionary<string, Job> job)
        {
            string filePath =
                $@"{AppDomain.CurrentDomain.BaseDirectory}\character";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath += @"\jobs.json";

            using (FileStream fs = File.Create(filePath))
            {
                await JsonSerializer.SerializeAsync(fs, job);
            }
        }
        public static async Task Save(HashSet<string> gender)
        {
            string filePath =
                $@"{AppDomain.CurrentDomain.BaseDirectory}\character";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath += @"\genders.json";

            using (FileStream fs = File.Create(filePath))
            {
                await JsonSerializer.SerializeAsync(fs, gender);
            }
        }

        public static async Task LoadSave()
        {
            string filePath =
             $@"{AppDomain.CurrentDomain.BaseDirectory}\character";
            string characterPath = filePath + @"\characters.json";
            string genderPath = filePath + @"\genders.json";
            string racePath = filePath + @"\races.json";
            string jobPath = filePath + @"\jobs.json";

            
            try
            {
                using (FileStream fs = File.OpenRead(characterPath))
                {
                    characters = await JsonSerializer.DeserializeAsync<Dictionary<string, Character>>(fs);
                }
            }
            catch
            {
                Console.WriteLine("failed with character");
            }
            try
            {
                using (FileStream fs = File.OpenRead(genderPath))
                {
                    genders = await JsonSerializer.DeserializeAsync<HashSet<string>>(fs);
                }
            }
            catch
            {
                Console.WriteLine("failed with genders");
            }
            try
            {
                using (FileStream fs = File.OpenRead(racePath))
                {
                    races = await JsonSerializer.DeserializeAsync<Dictionary<string, Race>>(fs);
                }
            }
            catch
            {
                Console.WriteLine("failed with races");
            }
            try
            {
                using (FileStream fs = File.OpenRead(jobPath))
                {
                    jobs = await JsonSerializer.DeserializeAsync<Dictionary<string, Job>>(fs);
                }
            }
            catch
            {
                Console.WriteLine("failed with jobs");
            }

        }
    }
}
