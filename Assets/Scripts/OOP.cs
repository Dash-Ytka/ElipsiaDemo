using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Animal dog1 = new Dog("������");
        Animal dog2 = new Dog("����");

        dog1.MakeSound();

        Dog dog = new Dog("�������");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("����");
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
        Debug.Log($"{name} �������.");
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
        Debug.Log($"{name} �������.");
    }

    public void Swim()
    {
        Debug.Log($"{name} �������.");
    }
}
class Program
{
    static void Main(string[] args )
    {
        Dog dog = new Dog("�������");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("����");
        duck.MakeSound();
        duck.Swim();
    }
}