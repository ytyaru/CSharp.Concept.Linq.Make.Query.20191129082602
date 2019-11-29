using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson3 {
    class Main {
        public void Run() {
            List<int> list = new List<int>() { 3, 1, 5, 4, 2 };
            Combinate1(list);
            Combinate2(list);
        }
        private void Combinate1(List<int> list) {
            IEnumerable<int> query = from v in list
                                     where 1 == (v % 2)
                                     select v;
            Console.WriteLine($"count: {query.Count()}");
        }
        private void Combinate2(List<int> list) {
            int count = (from v in list
                         where 1 == (v % 2)
                         select v).Count();
            Console.WriteLine($"count: {count}");
        }
    }
}
