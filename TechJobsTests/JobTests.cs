using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System.Net;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job3;
        Job test_job4;
        Job test_job5;

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job = new Job();
            Job test_job2 = new Job();
            Assert.IsFalse(test_job.Id == test_job2.Id);
        }

        [TestInitialize]
        public void CreateJobObject()
        {
            test_job3 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job4 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job5 = new Job("Product Tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobFields()
        {
            

            Assert.IsTrue(test_job3.Name == "Product Tester");
            Assert.IsTrue(test_job3.EmployerName.Value == "ACME");
            Assert.IsTrue(test_job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(test_job3.JobType.Value == "Quality Control");           
            Assert.IsTrue(test_job3.JobCoreCompetency.Value == "Persistence");         

        }

        [TestMethod]
        public void TestEquals()
        {
            Equals(test_job3, test_job4);
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.IsTrue(test_job5.ToString() == ($"ID:  {test_job5.Id}" +
                $"Name: {test_job5.Name}" +
                $"Employer: Data not found." +
                $"Location: {test_job5.EmployerLocation}" +
                $"Position Type: {test_job5.JobType}" +
                $"Core Competency: {test_job5.JobCoreCompetency}") );
        }
    }
}


  

