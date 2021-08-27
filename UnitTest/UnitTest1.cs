using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectSerializeLib;
using System;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSerializedWork()
        {
            PlayerData dataTest = new PlayerData();
            Serializer serializer = new Serializer();
            string path = Directory.GetCurrentDirectory() + "/Test/TestPlayerData.bin";

            try
            {
                serializer.SerializeData(dataTest, path);
            }
            catch (Exception e)
            {

            }
            
        }
    }
}
