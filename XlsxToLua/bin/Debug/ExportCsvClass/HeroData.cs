using System;
using System.Collections.Generic;

namespace Assets.Scripts.CsvClass
{
    public class HeroData
    {
        public int heroId { get; set; }
        public string name { get; set; }
        public int rare { get; set; }
        public int type { get; set; }
        public int defaultStar { get; set; }
        public bool isOpen { get; set; }
        public LitJson.JsonData attributes { get; set; }
    }
}
