namespace OldMacDonaldChallenge.PolymorphismSolution
{
    public abstract class Animal
    {
        public string Name { get; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string Sound { get; }

        public virtual void SingSong()
        {
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine($"And on his farm he had a {Name}, E-I-E-I-O");
            Console.WriteLine($"With a {Sound}-{Sound} here and a {Sound}-{Sound} there");
            Console.WriteLine($"Here a {Sound}, there a {Sound}, everywhere a {Sound}-{Sound}");
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine();
        }
    }

    public class Cow : Animal
    {
        public Cow():base("cow"){ }
        public override string Sound => "moo";
    }
    
    public class Duck : Animal
    {
        public Duck():base("duck"){ }
        public override string Sound => "quack";
    }
    
    public class Dog : Animal
    {
        public Dog():base("dog"){ }
        public override string Sound => "woof";
    }
    
    public class Sheep : Animal
    {
        public Sheep():base("sheep"){ }
        public override string Sound => "bee";
    }
    
    public class Pig : Animal
    {
        public Pig():base("pig"){ }
        public override string Sound => "oink";
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Cow(),
                new Duck(),
                new Dog(),
                new Pig(),
                new Sheep(),
            };

            foreach (var animal in animals)
            {
                animal.SingSong();
            }
        }
    }
}