namespace ChallangeApp.tests
{
    public class UserTest1
    {

        [Test]
        public void WhenUserScoresAreSumm_ResultShouldAboveZero()
        {
            //arrange
            var employee = new Employee("Mark", "Simpson", 20);
            //act
            employee.Addscores(5);
            employee.Addscores(3);
            employee.Addscores(1);
            //assert
            Assert.AreEqual(9, employee.result);
        }
        [Test]
        public void WhenUserScoresAreSumm_ResultShouldEqualZero()
        {
            //arrange
            var employee = new Employee("Mark", "Dimson", 21);
            //act
            employee.SubstractScores(4);
            employee.Addscores(3);
            employee.Addscores(1);
            //assert
            Assert.AreEqual(0, employee.result);
        }
        [Test]
        public void WhenUserScoresAreSumm_ResultShouldBelowZero()
        {
            //arrange
            var employee = new Employee("Mark", "Pinson", 22);
            //act
            employee.SubstractScores(4);
            employee.SubstractScores(0);
            employee.SubstractScores(4);

            //assert
            Assert.AreEqual(-8, employee.result);
        }

    }
}