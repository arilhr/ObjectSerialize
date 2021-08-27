using System;
using System.IO;
using ObjectSerializeLib;

namespace DeserializeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // initiate object deserializer
            Deserializer deserializer = new Deserializer();

            // set file path
            string path = Directory.GetCurrentDirectory() + "/PlayerData.bin";

            // run deserializer file
            PlayerData data = deserializer.DeserializeData(path);

            // show player data
            data.ShowData();

            // close program
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
