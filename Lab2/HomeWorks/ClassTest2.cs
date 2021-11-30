namespace Lab2.HomeWorks
{
    public class ClassTest2 : AClassTest, Interface
    {
        public ClassTest2(string name, int age)
            :base(name, age)
        {
        }
        public override string Print()
        {
            return "It is ClassTest2";
        }
        string Interface.PrintFromInterface()
        {
            return "It is ClassTest2Interface";
        }
    }
}