using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ObjectSerializeLib
{
    public class Serializer
    {
        public void SerializeData(PlayerData data, string path)
        {
            // initialize binary formatter
            BinaryFormatter formatter = new BinaryFormatter();
            // create file in path
            FileStream stream = new FileStream(path, FileMode.Create);

            // serialize data
            formatter.Serialize(stream, data);

            // close file
            stream.Close(); 
        }
    }
}
