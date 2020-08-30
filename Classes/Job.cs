using System;
using System.Text.Json.Serialization;

namespace Character_Builder.Classes
{
    public class Job : IJob, IComparable
    {
        [JsonPropertyName("jobName")]
        public string jobName {set;get;}
        [JsonPropertyName("jobAction")]
        public string jobAction { set; get; }

        public Job()
        {
        }
        public Job(string jobName)
        {
            this.jobName = jobName;
        }

        public Job(string jobName, string jobAction)
        {
            this.jobName = jobName;
            this.jobAction = jobAction;
        }

        public void work()
        {
            Console.WriteLine($"{jobAction} as a {jobName}");
        }


        public int CompareTo(object obj)
        {
            int i = 0;
            Job j = obj as Job;
            if(j != null)
            {
                i = string.Compare(jobName, j.jobName);
            }
            return i;
        }

        public override string ToString()
        {
            return $"{jobAction} as a {jobName}";
        }
    }
}
