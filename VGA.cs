namespace VGA;

class Vga
{
    public string Merk;
}

class Nvidia : Vga
{
    public Nvidia() => base.Merk = "Nvidia";
}

class AMD : Vga
{
    public AMD() => base.Merk = "AMD";
}
