using System;

// Інтерфейс або абстрактний клас для Ялинки
public interface IChristmasTree
{
    void Display();
}

// Звичайна Ялинка - конкретний клас
public class BaseChristmasTree : IChristmasTree
{
    public void Display()
    {
        Console.WriteLine("Це звичайна ялинка");
    }
}

// Декоратор для прикрас
public class AdorntmentDecorator : IChristmasTree
{
    private readonly IChristmasTree _christmasTree;

    public AdorntmentDecorator(IChristmasTree _christmasTree)
    {
        this._christmasTree = _christmasTree;
    }

    public void Display()
    {
        _christmasTree.Display();
        Console.WriteLine("Додаємо прикраси до ялинки");
    }
}

// Декоратор для гірлянд
public class GarlandDecorator : IChristmasTree
{
    private readonly IChristmasTree _christmasTree;

    public GarlandDecorator(IChristmasTree _christmasTree)
    {
        this._christmasTree = _christmasTree;
    }

    public void Display()
    {
        _christmasTree.Display();
        Console.WriteLine("Додаємо гірлянду до ялинки");
    }

    public void Shine()
    {
        Console.WriteLine("Ялинка світиться");
    }
}

// Приклад використання
class Program
{
    static void Main()
    {
        // Створення звичайної ялинки
        IChristmasTree baseChristmasTree = new BaseChristmasTree();

        // Додаємо прикраси
        IChristmasTree christmasTreeWithAdorntment = new AdorntmentDecorator(baseChristmasTree);

        // Додаємо гірлянду
        GarlandDecorator christmasTreeWithGarland = new GarlandDecorator(christmasTreeWithAdorntment);

        // Вивід на екран
        christmasTreeWithGarland.Display();

        // Світиться ялинка (якщо гірлянда додає цю функціональність)
        christmasTreeWithGarland.Shine();
    }
}

