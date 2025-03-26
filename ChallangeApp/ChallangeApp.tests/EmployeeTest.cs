namespace ChallangeApp.tests
{
    public class EmployeeTest
    {

        [Test]
        public void WhenUserScoresAreMax_ResultShouldEqualZero()
        {
            //arrange
            var employee = new EmployeeInFile("Mark", "Edmos");
            //act          
            employee.AddGrade('z');
            employee.AddGrade("gg");
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual(0, statistic.Max);
        }
        [Test]
        public void WhenUserScoresAreAverage_ResultShouldEqual1()
        {
            //arrange
            var employee = new Employee();
            //act          
            employee.AddGrade(1);
            employee.AddGrade(250);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual(1, statistic.Avarege);
        }
        [Test]
        public void WhenUserScoresAreMin_ResultShouldEqualPi()
        {
            //arrange
            var employee = new Employee();
            //act          
            employee.AddGrade(9.5);
            employee.AddGrade(10.5);
            employee.AddGrade(Math.PI);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual((float)Math.PI, statistic.Min);
        }
        [Test]
        public void FinalResultB()
        {
            //arrange
            var employee = new Employee();
            //act          
            employee.AddGrade('d');
            employee.AddGrade('a');

            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual('B', statistic.AverageLetter);
        }
        [Test]
        public void FinalResultE()
        {
            //arrange
            var employee = new Employee();
            //act          
            employee.AddGrade(1);
            employee.AddGrade('d');
            employee.AddGrade('5');
            employee.AddGrade(5);
            //assert
            var statistic = employee.GetStatistics();

            Assert.AreEqual('E', statistic.AverageLetter);
        }
    }
}