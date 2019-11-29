using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson0 {
    class Main {
        public void Run() {
            List<int> list = new List<int>() { 3, 1, 5, 4, 2 };
            Odds(list);
            Sort(list);
            Group();
        }
        private void Odds(List<int> list) {
            IEnumerable<int> query = from v in list
                                    where 1 == (v % 2)
                                    select v;
            Console.WriteLine($"{string.Join(",", query.ToList())}");
        }
        private void Sort(List<int> list) {
            IEnumerable<int> query = from v in list
                                    orderby v ascending
                                    select v;
            Console.WriteLine($"{string.Join(",", query.ToList())}");
        }
        private void Group() {
            string[] list = new string[] { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> query =
                from item in list
                group item by item[0];
            foreach (var g in query) {
                Console.WriteLine($"group: {g.Key}");
                foreach (var v in g) {
                    Console.WriteLine($"  {v}");
                }
            }
        }
    }
}
