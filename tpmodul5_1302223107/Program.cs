using System;

public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.WriteLine("Masukkan nama panggilan Anda:");
        string namaPanggilan = Console.ReadLine(); 
        halo.SapaUser(namaPanggilan);
    }
}
