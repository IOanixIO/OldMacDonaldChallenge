namespace OldMacDonaldChallenge.ExtendedVersion
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

    public class GenericAnimal : Animal
    {
        private readonly string _sound;

        public GenericAnimal(string name, string sound) : base(name)
        {
            _sound = sound;
        }

        public override string Sound
        {
            get { return _sound; }
        }
    }
    
    public static class AnimalFactory
    {
        public static List<Animal> CreateAllAnimals()
        {
            var animals = new List<Animal>
            {
                new Cow(),
                new Duck(),
                new Dog(),
                new Sheep(),
                new Pig()
            };

            var extraAnimalData = new List<(string Name, string Sound)>
            {
                ("cat", "meow"),
                ("horse", "neigh"),
                ("goat", "maa"),
                ("chicken", "cluck"),
                ("turkey", "gobble"),
                ("frog", "ribbit"),
                ("donkey", "hee-haw"),
                ("bee", "buzz"),
                ("owl", "hoot"),
                ("lion", "roar")
            };

            foreach (var data in extraAnimalData)
            {
                animals.Add(new GenericAnimal(data.Name, data.Sound));
            }

            return animals;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = AnimalFactory.CreateAllAnimals();

            foreach (var animal in animals)
            {
                animal.SingSong(); 
            }
        }
    }
}