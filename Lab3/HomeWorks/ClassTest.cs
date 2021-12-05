using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable<ClassTest>
    {

        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(ClassTest? obj)
        {
            if (obj != null)
            {
                if (this.Age < obj.Age) 
                    return -1;
                else if (this.Age > obj.Age) 
                    return 1;
                else 
                    return 0;
            }
            else throw new Exception();
        }
        public override bool Equals(object? other)
        {
            if (other != null) return this.Name == ((ClassTest)other).Name && this.Age == ((ClassTest)other).Age;
            else return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}