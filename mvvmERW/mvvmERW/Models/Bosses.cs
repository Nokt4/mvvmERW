using System;
using System.Collections.Generic;
using System.Text;

namespace mvvmERW.Models
{
    internal class Bosses
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public string Location { get; set; }
        public double Drops { get; set; }

        public static Bosses[] GetBosses()
        { 
            var result = new Bosses[]
            {
                new Bosses() { Name = "GODRICK THE GRAFTED", HP = 6080  , Location = "Stormveil Castle", Drops = 20000},
                new Bosses() { Name = "RENNALA, QUEEN OF THE FULL MOON", HP = 7590, Location = "Raya Lucaria Academy, Liurnia of the Lakes", Drops = 40000},
                new Bosses() { Name = "STARSCOURGE RADAHN", HP = 9572, Location = "Caelid", Drops = 70000},
                new Bosses() { Name = "MORGOTT, THE OMEN KING", HP = 10399, Location = "Leyndell", Drops = 120000},
                new Bosses() { Name = "RYKARD, LORD OF BLASPHEMY", HP = 59174, Location = "Mt. Gelmir", Drops = 100000},
                new Bosses() { Name = "MOHG, LORD OF BLOOD", HP = 18389, Location = "Mohgwyn Palace", Drops = 315000},
                new Bosses() { Name = "MALENIA, BLADE OF MIQUELLA", HP = 18473, Location = "Elphael, Brace of the Haligtree", Drops = 480000},
                new Bosses() { Name = "MALIKETH, THE BLACK BLADE", HP = 10620, Location = "Crumbling Farum Azula", Drops = 220000},
                new Bosses() { Name = "GODFREY, FIRST ELDEN LORD", HP = 22000, Location = "Leyndell, Capital of Ash", Drops = 300000},
                new Bosses() { Name = "FIRE GIANT", HP = 22898, Location = "Mountaintops of the Giants", Drops = 180000},
                new Bosses() { Name = "RADAGON OF THE GOLDEN ORDER", HP = 13339, Location = "Elden Throne", Drops = 0},
                new Bosses() { Name = "ELDEN BEAST", HP = 22127, Location = "Elden Throne", Drops = 500000},  
            };
            return result;
            
        }
    }
}
