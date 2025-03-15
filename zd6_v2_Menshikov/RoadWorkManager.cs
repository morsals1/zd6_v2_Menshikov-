using System;
using System.Collections.Generic;
using System.Linq;

namespace zd6_v2_Menshikov
{
    public static class RoadWorkManager
    {
        public static List<RoadWork> RoadWorks { get; set; } = new List<RoadWork>();
        public static Dictionary<string, RoadWork> RoadWorkDictionary { get; set; } = new Dictionary<string, RoadWork>();

        public static void AddRoadWork(RoadWork roadWork)
        {
            RoadWorks.Add(roadWork);
        }

        public static void AddRoadWork(RoadWork roadWork, string key)
        {
            RoadWorkDictionary.Add(key, roadWork);
        }

        public static void AddRoadWork(List<RoadWork> roadWorks)
        {
            RoadWorks.AddRange(roadWorks);
        }

        public static void RemoveRoadWork(RoadWork roadWork)
        {
            RoadWorks.Remove(roadWork);
        }

        public static void RemoveRoadWork(string key)
        {
            if (RoadWorkDictionary.ContainsKey(key))
            {
                RoadWorkDictionary.Remove(key);
            }
        }

        public static void RemoveRoadWork(List<RoadWork> roadWorks)
        {
            foreach (var roadWork in roadWorks)
            {
                RoadWorks.Remove(roadWork);
            }
        }

        public static List<RoadWork> GetHighQualityRoadWorks(double threshold)
        {
            return RoadWorks.Where(r => r.CalculateQuality() > threshold).ToList();
        }
    }
}