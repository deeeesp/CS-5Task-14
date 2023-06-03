using Task5.Entity;
using Task5.Entity.Enums;

internal static class Program
{
    static void Main()
    {
        InkjetPrinter inkjetPrinter = new InkjetPrinter()
        {
            printingSpeed = 100,
            Cost = 15000,
            maxFormat = 600,
            TypeColorPrintig = "color"
        };
        Console.WriteLine("---");
        foreach (var cartridge in inkjetPrinter.cartridges)
        {
            Console.WriteLine(cartridge);
            
        }
        Console.WriteLine("---");
        inkjetPrinter.fillPrinter();
        foreach (var cartridge in inkjetPrinter.cartridges)
        {
            Console.WriteLine(cartridge);
        }
        Console.WriteLine(inkjetPrinter.buyPrinter());
    }
}