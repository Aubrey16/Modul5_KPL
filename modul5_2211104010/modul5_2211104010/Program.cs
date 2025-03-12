using System;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}

class Program
{
    static void Main()
    {

        int angka1 = 12;
        int angka2 = 34;
        int angka3 = 56;

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
