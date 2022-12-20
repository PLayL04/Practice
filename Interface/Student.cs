namespace Interface
{
    internal class Student
    {
        public string Name;
        public Dictionary<string, int> Practical = new Dictionary<string, int>();
        public Dictionary<string, int> Control = new Dictionary<string, int>();
        public Student(string name)
        {
            Name = name;
        }
    }
}
