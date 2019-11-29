using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson2 {
    class Main {
        public void Run() {
            List<int> list = new List<int>() { 3, 1, 5, 4, 2 };
            Functions(list);
            Concat(list);
        }
        private void Functions(List<int> list) {
            IEnumerable<int> query = from v in list
                                     where 1 == (v % 2)
                                     select v;
            Console.WriteLine($"{string.Join(",", query.ToList())}");
            Console.WriteLine($"Average(): {query.Average()}");
            Console.WriteLine($"Sum(): {query.Sum()}");
            Console.WriteLine($"Max(): {query.Max()}");
            Console.WriteLine($"Min(): {query.Min()}");
        }
        private void Concat(List<int> list) {
            List<int> list2 = new List<int>() { 9, 7, 0, 8, 6 };
//            Console.WriteLine($"Concat(): {list.Concat(list2).ToList()}");
            Console.WriteLine($"Concat(): {string.Join(",", list.Concat(list2).ToList())}");
        }
    }
}
