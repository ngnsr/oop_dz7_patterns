using System;

// Підсистема для приготування паста
class PastaCooking
{
    public void PrepareIngredients()
    {
        Console.WriteLine("Приготування інгредієнтів для пасти");
    }

    public void Cook()
    {
        Console.WriteLine("Приготування пасти");
    }

    public void Serve()
    {
        Console.WriteLine("Подача пасти");
    }
}

// Підсистема для приготування омлету
class OmeletteCooking
{
    public void PrepareIngredients()
    {
        Console.WriteLine("Приготування інгредієнтів для омлету");
    }

    public void Cook()
    {
        Console.WriteLine("Приготування омлету");
    }

    public void Serve()
    {
        Console.WriteLine("Подача омлету");
    }
}

// Підсистема для приготування супу
class SoupCooking
{
    public void PrepareIngredients()
    {
        Console.WriteLine("Приготування інгредієнтів для супу");
    }

    public void Cook()
    {
        Console.WriteLine("Приготування супу");
    }

    public void Serve()
    {
        Console.WriteLine("Подача супу");
    }
}

// Підсистема для приготування стейку
class SteakCooking
{
    public void PrepareIngredients()
    {
        Console.WriteLine("Приготування інгредієнтів для стейку");
    }

    public void Cook()
    {
        Console.WriteLine("Приготування стейку");
    }

    public void Serve()
    {
        Console.WriteLine("Подача стейку");
    }
}

// Фасад для Мультиварки
class MulticookerFacade
{
    private readonly PastaCooking pastaCooking;
    private readonly OmeletteCooking omeletteCooking;
    private readonly SoupCooking soupCooking;
    private readonly SteakCooking steakCooking;

    public MulticookerFacade()
    {
        pastaCooking = new PastaCooking();
        omeletteCooking = new OmeletteCooking();
        soupCooking = new SoupCooking();
        steakCooking = new SteakCooking();
    }

    // Метод для приготування паста
    public void CookPasta()
    {
        pastaCooking.PrepareIngredients();
        pastaCooking.Cook();
        pastaCooking.Serve();
    }

    // Метод для приготування омлету
    public void CookOmelette()
    {
        omeletteCooking.PrepareIngredients();
        omeletteCooking.Cook();
        omeletteCooking.Serve();
    }

    // Метод для приготування супу
    public void CookSoup()
    {
        soupCooking.PrepareIngredients();
        soupCooking.Cook();
        soupCooking.Serve();
    }

    // Метод для приготування стейку
    public void CookSteak()
    {
        steakCooking.PrepareIngredients();
        steakCooking.Cook();
        steakCooking.Serve();
    }
}

class Program
{
    static void Main()
    {
        // Використання фасаду для приготування паста
        MulticookerFacade multicooker = new MulticookerFacade();
        multicooker.CookPasta();

        Console.WriteLine();

        // Використання фасаду для приготування омлету
        multicooker.CookOmelette();

        Console.WriteLine();

        // Використання фасаду для приготування супу
        multicooker.CookSoup();

        Console.WriteLine();

        // Використання фасаду для приготування стейку
        multicooker.CookSteak();
        Console.Read();
    }
}

