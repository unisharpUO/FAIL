using ScriptSDK.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAIL
{
    public class Loot
    {
        private string _lootName;
        private uint _lootType;

        public string LootName
        {
            get { return _lootName; }
            set { _lootName = value; }
        }

        public uint LootType
        {
            get { return _lootType; }
            set { _lootType = value; }
        }

        public Loot()
        {
        }

        public Loot(Item Item)
        {
            Item.UpdateTextProperties();
            LootName = Item.Tooltip.Split('|')[0].Replace("'", "");
            LootType = Item.ObjectType;
        }
        
        public Loot(string Name)
        {
            LootName = Name;
        }

        public Loot(uint Type)
        {
            LootType = Type;
        }

    }
}
