namespace Week7Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Animal> animals = new List<Animal>();


            Animal animal2 = new Dog();
            animals.Add(animal2);
            Animal animal3 = new Snake();
            animals.Add(animal3);
            Dog animal4 = new Dog();
            animals.Add(animal4);
            Snake animal5 = new Snake();
            animals.Add(animal5);

            foreach (Animal animal in animals)
            {
                animal.Move();
             //   Dog dog1 = (Dog)animal;
                Dog dog2=animal as Dog;
                dog2.Eat();

                //if (animal is Dog dog)
                //{
                //    dog.Eat();
                //}
            }

        }
    }
}
