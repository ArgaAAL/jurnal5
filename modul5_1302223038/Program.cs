using System;
<<<<<<< HEAD
=======
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class SimpleDataBase<T>
{
    private List<T>  storedData;
    private List<DateTime> inputDates = new List<DateTime>();

    public SimpleDataBase()
    {
        storedData = new List<T>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int i = 1;
        foreach (T data in storedData)
        {
            Console.WriteLine("Data {0} berisi: {1}, yang disimpan pada waktu UTC: {2}", i, data, DateTime.Now);
            i++;
        }
    }
}
>>>>>>> implementasi-generic-class

class Program
{
    static void Main(string[] args)
    {
        //NIM 1302223038
<<<<<<< HEAD
        Penjumlahan.JumlahTigaAngka<int>(13,02,22);
=======
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        simpleDataBase.AddNewData(13);
        simpleDataBase.AddNewData(02);
        simpleDataBase.AddNewData(22);
        simpleDataBase.PrintAllData();
>>>>>>> implementasi-generic-class

    }
}