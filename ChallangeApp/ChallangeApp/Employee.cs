namespace ChallangeApp
{
    public class Employee
    {
        public Employee(string name, string surname, int age, int result)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Surname { get; private set; }

        
        private List<int> score = new List<int>();

        public int Result
        {
            get {return this.score.Sum();}
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
