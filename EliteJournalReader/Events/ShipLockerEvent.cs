using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class ShipLockerEvent : JournalEvent<ShipLockerEvent.ShipLockerEventArgs>
    {
        public ShipLockerEvent() : base("ShipLocker") { }

        public class ShipLockerEventArgs : JournalEventArgs
        {
            public List<Item> Items { get; set; }
            public List<Component> Components { get; set; }
            public List<Consumable> Consumables { get; set; }
            public List<Datum> Data
            {
                get; set;
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public string Name_Localised { get; set; }
            public int OwnerID { get; set; }
            public int MissionID { get; set; }
            public int Count { get; set; }
        }

        public class Component
        {
            public string Name { get; set; }
            public int OwnerID { get; set; }
            public int Count { get; set; }
            public string Name_Localised { get; set; }
        }

        public class Consumable
        {
            public string Name { get; set; }
            public string Name_Localised { get; set; }
            public int OwnerID { get; set; }
            public int Count { get; set; }
        }

        public class Datum
        {
            public string Name { get; set; }
            public string Name_Localised { get; set; }
            public int OwnerID { get; set; }
            public int Count { get; set; }
        }
    }
}