using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Animal dog1 = new Dog("Хатико");
        Animal dog2 = new Dog("Граф");

        dog1.MakeSound();

        Dog dog = new Dog("Шницель");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("Кряк");
        duck.MakeSound();
        duck.Swim();
    }

}

public abstract class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{name} makes a sound.");
    }
}

public class Dog : Animal
{
    public static int dogCount = 0;

    public Dog(string name) : base(name)
    {
        dogCount++;
    }

    public override void MakeSound()
    {
        Debug.Log($"{name} тяфкает.");
    }

    public static void PrintHowManyDogs()
    {
        Debug.Log($"There are {dogCount} dogs.");
    }
}

public interface ISwimming
{
    void Swim();
}

public class Duck : Animal, ISwimming
{
    public Duck(string name) : base(name) { }

    public override void MakeSound()
    {
        Debug.Log($"{name} крякает.");
    }

    public void Swim()
    {
        Debug.Log($"{name} плавает.");
    }
}
class Program
{
    static void Main(string[] args )
    {
        Dog dog = new Dog("Шницель");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("Кряк");
        duck.MakeSound();
        duck.Swim();
    }
}