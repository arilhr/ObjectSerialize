using System;
using System.IO;
using ObjectSerializeLib;

namespace ObjectSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize data and serializer
            PlayerData data = new PlayerData();
            Serializer serializer = new Serializer();

            // path to save file
            string path = Directory.GetCurrentDirectory() + "/PlayerData.bin";

            // input data player
            data.InputData();

            // run object serializer to serialize data
            serializer.SerializeData(data, path);

            // close
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
