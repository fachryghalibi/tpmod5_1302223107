using System;
class program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }


    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T inputData)
        {
            data = inputData;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.WriteLine("Masukkan nama panggilan Anda:");
        string namaPanggilan = Console.ReadLine();
        halo.SapaUser(namaPanggilan);


        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223107");
        dataGeneric.PrintData();

    }
}