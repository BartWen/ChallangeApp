
namespace ChallangeApp.tests
{
    public class TypeTest
    {
        [Test]

        public void NumbersShouldDifferent() 
        {
            //arrange
            var number1 = 15;
            var number2 = 15;
            //act

            //assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]

        public void StringShouldDifferent()
        {
            //arrange
            var name = "Bob";
            var name2 = "Fred";
            //act

            //assert
            Assert.AreNotEqual(name, name2);

        }



        [Test]
        public void GetEmployeeShouldReturnDifferentObject()
        {
            //arrange
            var user1 = GetEmployee("Mark", "Bomb", 33);
            var user2 = GetEmployee("Clark", "Bomb", 33);            
            //act

            //assert
            Assert.AreEqual(user1.age, user2.age);
        }

        private Employee GetEmployee(string name, string surname, int age )
        {
            return new Employee(name,surname,age);
        }
    }
}
