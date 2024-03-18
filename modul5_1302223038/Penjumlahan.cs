using System;

public class Penjumlahan
{

    public static void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic hasil1 = angka1;
        dynamic hasil2 = angka2;
        dynamic hasil3 = angka3;
        dynamic total = hasil1 + hasil2 + hasil3;

        Console.WriteLine("Hasil penjumlahan NIM adalah {0}",total);
    }
}