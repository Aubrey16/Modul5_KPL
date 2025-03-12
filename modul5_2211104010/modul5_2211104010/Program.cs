using System;
using System.Collections.Generic;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Gunakan dua digit NIM sesuai aturan
        int angka1 = 12;
        int angka2 = 34;
        int angka3 = 56;

        // Gunakan SimpleDataBase
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(angka1);
        db.AddNewData(angka2);
        db.AddNewData(angka3);
        
        // Cetak hasil
        db.PrintAllData();
    }
}
