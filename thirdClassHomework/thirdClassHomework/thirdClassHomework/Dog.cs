using System;

namespace thirdClassHomework
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        public static void Validate(Dog dog)
        {
            bool validateDog = false;
            if (dog.Name.Length >= 2 || dog.Id > 0 || string.IsNullOrEmpty(dog.Color))
            {
                Console.WriteLine($"All the of the properties are set for the object {dog.Name}");
                
            }else
            {
                Console.WriteLine("Inavlid input");
            }
        }

        public override string ToString()
        {
            return $"Dog, id: {Id}, name: {Name}, color: {Color}";
        }
    }
}
