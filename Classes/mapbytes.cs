using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pso;

namespace pso
{
    internal class MapBytes
    {
        public byte Byte_1 { get; set; } = 0x00;
        public byte Byte_2 { get; set; } = 0x00;
        public string map;
        public string niceName;
        public string mapReaderDisplay;
        public IntPtr addr;
        IDictionary<int, byte[]> variation;
        public string[] variationStrings;

        public MapBytes(string mapName)
        {
            map = mapName;
            switch(map)
            {
                case "forest_1":
                    niceName = "Forest 1";
                    addr = 0x333080;
                    variationStrings = new string[3] { "A", "B", "C" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "forest_2":
                    niceName = "Forest 2";
                    addr = 0x333088;
                    variationStrings = new string[3] { "A", "B", "C" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "caves_1":
                    niceName = "Caves 1";
                    addr = 0x333090;
                    variationStrings = new string[3] { "A", "B", "C" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2,  new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 3,  new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "caves_2":
                    niceName = "Caves 2";
                    addr = 0x333098;
                    variationStrings = new string[3] { "A", "B", "C" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2,  new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 3,  new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "caves_3":
                    niceName = "Caves 3";
                    addr = 0x3330A0;
                    variationStrings = new string[3] { "A", "B", "C" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1,  new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2,  new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 3,  new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "mines_1":
                    niceName = "Mines 1";
                    addr = 0x3330A8;
                    variationStrings = new string[6] { "1A", "1B", "2A", "2B", "3A", "3B" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 4, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 5, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 6, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "mines_2":
                    niceName = "Mines 2";
                    addr = 0x3330B0;
                    variationStrings = new string[6] { "1A", "1B", "2A", "2B", "3A", "3B" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 4, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 5, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 6, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "ruins_1":
                    niceName = "Ruins 1";
                    addr = 0x3330B8;
                    variationStrings = new string[6] { "1A", "1B", "2A", "2B", "3A", "3B" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 4, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 5, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 6, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "ruins_2":
                    niceName = "Ruins 2";
                    addr = 0x3330C0;
                    variationStrings = new string[6] { "1A", "1B", "2A", "2B", "3A", "3B" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 4, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 5, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 6, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } }
                    };
                    break;
                case "ruins_3":
                    niceName = "Ruins 3";
                    addr = 0x3330C8;
                    variationStrings = new string[6] { "1A", "1B", "2A", "2B", "3A", "3B" };
                    variation = new Dictionary<int, byte[]>()
                    {
                        { 1, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 2, new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 3, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 4, new byte[8] { 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } },
                        { 5, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } },
                        { 6, new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00 } }
                    };
                    break;
                default:
                    addr = 0x000000;
                    break;
            }
        }

        public string getMapVariation(psoapi pso)
        {
            byte[] byteCmp = pso.ReadBytes((int)addr, 8);
            mapReaderDisplay = niceName + ": ";
            if (byteCmp.SequenceEqual(variation[1]))
            {
                mapReaderDisplay += variationStrings[0];
            }
            else if (byteCmp.SequenceEqual(variation[2]))
            {
                mapReaderDisplay += variationStrings[1];
            }
            else if (byteCmp.SequenceEqual(variation[3]))
            {
                mapReaderDisplay += variationStrings[2];
            }
            else if (byteCmp.SequenceEqual(variation[4]))
            {
                mapReaderDisplay += variationStrings[3];
            }
            else if (byteCmp.SequenceEqual(variation[5]))
            {
                mapReaderDisplay += variationStrings[4];
            }
            else if (byteCmp.SequenceEqual(variation[6]))
            {
                mapReaderDisplay += variationStrings[5];
            } 
            return mapReaderDisplay;
        }
    }
}
