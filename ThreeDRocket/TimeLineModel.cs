using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDRocket
{
    internal class TimeLineModel
    {
        public class Coordinate
        {
            public Coordinate()
            {
                id = TimeLineModel.identity;
                TimeLineModel.identity += 1;
            }

            public int x { get; set; }
            public int y { get; set; }
            private int id { get; set; }
            public int identity { get 
                { 
                    return id; 
                }
            }
        }
        public static int identity = 1;

        public static List<Coordinate> data = new List<Coordinate>();

        public TimeLineModel()
        {
            var sdata = File.ReadAllText(@"C:\Users\eminn\OneDrive\Desktop\timelineOrion.json");
            data = JsonConvert.DeserializeObject<List<Coordinate>>(sdata);
        }
    }
}
