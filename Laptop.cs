using CPU;
using VGA;

class Laptop
{
    public string Merk, Tipe;
    public Vga Vga;
    public Processor Processor;

    public void LaptopDinyalakan()
        => Console.WriteLine($"Laptop {Merk} {Tipe} menyala");

    public void LaptopDimatikan()
        => Console.WriteLine($"Laptop {Merk} {Tipe} mati");
}


// Asus Family
class Asus : Laptop
{
    public Asus() => base.Merk = "Asus";
}

class ROG : Asus
{
    public ROG() => base.Tipe = "ROG";
}

class Vivobook : Asus
{
    public Vivobook() => base.Tipe = "Vivobook";

    public void Ngoding()
        => Console.WriteLine("Ctak, Ctak, Ctak. Error lagi!");
}


// Acer Family
class Acer : Laptop
{
    public Acer() => base.Merk = "Acer";
}

class Swift : Acer
{
    public Swift() => base.Tipe = "Swift";
}

class Predator : Acer
{
    public Predator() => base.Tipe = "Predator";
    public void BermainGame()
        => Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
}

//Lenovo Family
class Lenovo : Laptop
{
    public Lenovo() => base.Merk = "Lenovo";
}

class Ideapad : Lenovo
{
    public Ideapad() => base.Tipe = "Ideapad";
}

class Legion : Lenovo
{
    public Legion() => base.Tipe = "Legion";
}