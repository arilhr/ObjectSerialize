using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjectSerializeLib
{
    public class Deserializer
    {
        
        public PlayerData DeserializeData(string path)
        {
            // make a blank player data
            PlayerData data = new PlayerData();

            if (File.Exists(path))
            {
                // initialize binary formatter
                BinaryFormatter formatter = new BinaryFormatter();
                // open file in path
                FileStream stream = new FileStream(path, FileMode.Open);

                // deserialize data
                data = formatter.Deserialize(stream) as PlayerData;

                // close file
                stream.Close();
            }
            else
            {
                Console.WriteLine("file not found..");
            }

            return data;
        }
    }
}
