// Інтерфейс для USB Type A
public interface IUsbTypeA
{
    void TransferData();
}

// Клас USB Type A
public class UsbTypeA : IUsbTypeA
{
    public void TransferData()
    {
        Console.WriteLine("Передача даних кабелем Type A");
    }
}

// Клас USB Type C
public class UsbTypeC
{
    public void TransferDataWithUsbTypeC()
    {
        Console.WriteLine("Передача даних кабелем Type C");
    }
}

// Адаптер для USB Type C
public class UsbTypeCAdapter : IUsbTypeA
{
    private readonly UsbTypeA usbTypeA;

    public UsbTypeCAdapter(UsbTypeA usbTypeA)
    {
        this.usbTypeA = usbTypeA;
    }

    public void TransferData()
    {
        Console.WriteLine("Передача даних використовуючи кабель Type C через адаптер до Type A");
        usbTypeA.TransferData();
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта USB Type A
        UsbTypeA usbTypeA = new UsbTypeA();

        // Створення об'єкта USB Type C
        UsbTypeC usbTypeC = new UsbTypeC();

        // Використання адаптера для виклику TransferData через USB Type C
        IUsbTypeA usbTypeCAdapter = new UsbTypeCAdapter(usbTypeA);

        // Вивід на екран
        usbTypeA.TransferData();
        usbTypeCAdapter.TransferData();
    }
}

