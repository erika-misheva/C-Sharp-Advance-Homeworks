using System;


namespace Generics_and_Extension_Homework
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        abstract public void PrintInfo();

        public Pet ( string name, string type, int age)
        { 
            Name = name;       
            Type = type;
            Age = age;
	    }
    }
}
