using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        public Job()
        {
            Id = nextId;
            nextId++;
        }
        // TODO: Add the two necessary constructors.
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {        
            if(Name == "")
            {
                Name = "Data not found.";
            }
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not found.";
            }
            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not found.";
            }
            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not found.";
            }
            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not found.";
            }
            //Thought to make Dictionary to loop through values and check for null/empty values. Didn't feel like the right answer.
            string speech = ($"ID:  {this.Id}\n" +
                $"Name: {this.Name}\n" +
                $"Employer: {this.EmployerName}\n" +
                $"Location: {this.EmployerLocation}\n" +
                $"Position Type: {this.JobType}\n" +
                $"Core Competency: {this.JobCoreCompetency}\n");


            return speech;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
