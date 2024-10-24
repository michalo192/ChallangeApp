namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestString()
        {
            //arrange
            var employee1 = GetEmployee("Michał", "Walencik", 32, 0);
            var employee2 = GetEmployee("Adam", "Kamizelich", 40, 0);

            //act

            //assert   
            Assert.AreNotEqual(employee1, employee2);           
        }
        private Employee GetEmployee(string name, string surname, int age, int result)
        {
            return new Employee(name, surname, age, result);
        }

        [Test]
        public void TestString2()
        {
            string person1 = "Krzycho";
            string perosn2 = "Zdzicho";

            Assert.AreNotEqual(person1, perosn2);
        }

        [Test]
        public void TestInts()
        {
            var number1 = 1;
            var number2 = 1;
        
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestFloats()
        {
            float number3 = 2.233f;
            float number4 = 9.9886f;

            Assert.AreNotEqual(number3, number4);

        }
    }
} 
