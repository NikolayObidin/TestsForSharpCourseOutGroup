namespace Lab2.HomeWorks
{

    public abstract class AClassTest 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AClassTest(string name, int age) 
        {
            Name = name; Age = age;
        }
        public abstract string Print();
    }
}