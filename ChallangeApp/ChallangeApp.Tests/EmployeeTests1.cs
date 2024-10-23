namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestingMethodAddScoreAtEmployee1()
        {
            // arange //
            var employee1 = new Employee("Micha³", "Walencik", 32, 0);
            employee1.AddScore(5);
            employee1.AddScore(5);
            employee1.AddScore(7);
            employee1.AddScore(8);
            employee1.AddScore(-5); //20//

            // act //
            var result1 = employee1.Result;

            // assert //  
            Assert.AreEqual(20, result1);
        }

        [Test]
        public void TestingMethodAddScoreAtEmployee2()
        {
            var employee2 = new Employee("Adam", "Kamizelich", 40, 0);
            employee2.AddScore(8);
            employee2.AddScore(9);
            employee2.AddScore(4);
            employee2.AddScore(6);
            employee2.AddScore(-8);
            employee2.AddScore(-4); //15//

            var result2 = employee2.Result;

            Assert.AreEqual(15, result2);
        }

        [Test]
        public void TestingMethodAddScoreAtEmployee3()
        {
            var employee3 = new Employee("Bartek", "Karski", 33, 0);
            employee3.AddScore(4);
            employee3.AddScore(10);
            employee3.AddScore(8);
            employee3.AddScore(2);
            employee3.AddScore(-3);
            employee3.AddScore(-2); //19//

            var result3 = employee3.Result;

            Assert.AreEqual(19, result3);
        }
    }
}