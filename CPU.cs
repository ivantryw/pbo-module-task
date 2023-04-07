namespace CPU;

class Processor
{
    public string Merk, Tipe;
}

// Intel Processor Family
class Intel : Processor
{
    public Intel() => base.Merk = "Intel";
}

class CoreI3 : Intel
{
    public CoreI3() => base.Tipe = "Core i3";
}

class CoreI5 : Intel
{
    public CoreI5() => base.Tipe = "Core i5";
}

class CoreI7 : Intel
{
    public CoreI7() => base.Tipe = "Core i7";
}

// AMD Processor Family
class AMD : Processor
{
    public AMD() => base.Merk = "AMD";
}

class Ryzen : AMD
{
    public Ryzen() => base.Tipe = "RYZEN";
}

class Athlon : AMD
{
    public Athlon() => base.Tipe = "ATHLON";
}
