using ObjectSerializeLib;
using System;
using System.IO;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        PlayerData dataTest = new PlayerData("Name Test", 10, 2000);
        string path = Directory.GetCurrentDirectory() + "/PlayerDataTest.bin";

        [Fact]
        public void SerializeWorkTest()
        {
            Serializer serializer = new Serializer();

            try
            {
                serializer.SerializeData(dataTest, path);
            }
            catch (Exception e)
            {
                Assert.True(false);
            }

            Assert.True(true);
        }

        [Fact]
        public void DeserializeWorkTest()
        {
            PlayerData data = new PlayerData();
            Deserializer deserializer = new Deserializer();

            try 
            {
                data = deserializer.DeserializeData(path);
            }
            catch (Exception e)
            {
                Assert.True(false);
            }

            Assert.True(true);
        }

        [Fact]
        public void IsThereCreatedFileTest()
        {
            Serializer serializer = new Serializer();
            serializer.SerializeData(dataTest, path);

            Assert.True(File.Exists(path));
        }

        [Fact]
        public void TestEqualData()
        {
            Serializer serializer = new Serializer();
            serializer.SerializeData(dataTest, path);

            PlayerData data = new PlayerData();
            Deserializer deserializer = new Deserializer();
            data = deserializer.DeserializeData(path);

            bool cond = true;
            if (data.playerName != dataTest.playerName) cond = false;
            if (data.level != dataTest.level) cond = false;
            if (data.gold != dataTest.gold) cond = false;

            Assert.True(cond);
        } 
    }
}
