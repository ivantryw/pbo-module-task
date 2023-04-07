class Program
{
    private static void Main()
    {
        Laptop laptop1 = new Vivobook()
        {
            Vga = new VGA.Nvidia(),
            Processor = new CPU.CoreI5()
        };

        Laptop laptop2 = new Ideapad()
        {
            Vga = new VGA.AMD(),
            Processor = new CPU.Ryzen()
        };

        Predator predator = new()
        {
            Vga = new VGA.AMD(),
            Processor = new CPU.CoreI7()
        };

        // Soal 1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        // Soal 2
        laptop1.Ngoding(); // Error

        // Soal 3: Menampilkan spesifikasi laptop1
        string laptop1Specs =
            $"Merk VGA: {laptop1.Vga.Merk}\n" +
            $"Merk CPU: {laptop1.Processor.Merk}\n" +
            $"Tipe CPU: {laptop1.Processor.Tipe}";

        Console.WriteLine(laptop1Specs);

        // Soal 4
        predator.BermainGame();

        // Soal 5
        Acer acer = new Predator();
        acer.BermainGame(); // Error
    }
}