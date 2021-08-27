using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSerializeLib
{
    [Serializable]
    public class PlayerData
    {
        public string playerName;
        public int level;
        public int gold;

        public PlayerData() { }

        public PlayerData(string playerName, int level, int gold)
        {
            this.playerName = playerName;
            this.level = level;
            this.gold = gold;
        }

        public void InputData()
        {
            Console.Write("Enter player name: ");
            playerName = Console.ReadLine();
            Console.Write("Enter player level: ");
            level = int.Parse(Console.ReadLine());
            Console.Write("Enter player gold: ");
            gold = int.Parse(Console.ReadLine());
        }

        public void ShowData()
        {
            Console.WriteLine(playerName);
            Console.WriteLine(level);
            Console.WriteLine(gold);
        }
    }
}
