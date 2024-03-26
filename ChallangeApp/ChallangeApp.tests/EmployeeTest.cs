namespace ChallangeApp.tests
{
    public class EmployeeTest
    {

        [Test]
        public void WhenUserScoresAreSumm_ResultShouldEqualMaxValue()
        {
            //arrange
            var employee = new Employee("Mark", "Simpson");
            //act
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(1);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual(5, statistic.Max);

        }

        [Test]
        public void WhenUserScoresAreSumm_ResultShouldEqualMinValue()
        {
            //arrange
            var employee = new Employee("Mark", "Simps");
            //act
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(1);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual(1,statistic.Min);

        }

        [Test]
        public void WhenUserScoresAreSumm_ResultShouldEqualAvarage()
        {
            //arrange
            var employee = new Employee("Mark", "Sim");
            //act
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(2);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.33,2),Math.Round(statistic.Avarege,2));

        }

    }
}