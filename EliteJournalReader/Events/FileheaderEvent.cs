using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class FileheaderEvent : JournalEvent<FileheaderEvent.FileheaderEventArgs>
    {
        public FileheaderEvent() : base("Fileheader") { }

        public class FileheaderEventArgs : JournalEventArgs
        {
            public int part { get; set; }
            public string language { get; set; }
            public bool Odyssey { get; set; }
            public string gameversion { get; set; }
            public string build { get; set; }
        }
    }
}
