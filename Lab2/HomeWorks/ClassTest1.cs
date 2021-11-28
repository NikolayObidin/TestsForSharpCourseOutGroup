namespace Lab2.HomeWorks
{
    public class ClassTest1 : AClassTest, Interface
    {    
        public ClassTest1(string name, int age)
            :base(name, age)
        {
        }
        public override string Print()
        { 
            return "It is ClassTest1";
        }

        string Interface.PrintFromInterface()
        {
            return "It is ClassTest1Interface";
        }
    }
}