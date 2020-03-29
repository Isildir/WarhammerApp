using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerProfessionApp.Utility
{
    internal class GraphFinder
    {
        public GraphFinder(IDictionary<int, List<int>> values, int maxDepth)
        {
            this.values = values;
            this.maxDepth = maxDepth <= 6 ? maxDepth : 6;
        }

        internal IList<Queue<int>> FindAllPaths(int startPoint, int endPoint)
        {
            var startingPath = new Queue<int>();
            startingPath.Enqueue(startPoint);

            if (startPoint == endPoint)
                return new List<Queue<int>> { startingPath };

            results = new List<Queue<int>>();

            CheckGraphElement(startPoint, endPoint, startingPath);

            return results.ToList();
        }

        private readonly int maxDepth;
        private readonly IDictionary<int, List<int>> values;
        private List<Queue<int>> results;

        private void CheckGraphElement(int startPoint, int endPoint, Queue<int> cache)
        {
            if (!(values.ContainsKey(startPoint) && cache.Count <= maxDepth))
                return;

            var currentDictionaryValue = values[startPoint];

            var tasks = new List<Task>();

            foreach (var value in currentDictionaryValue)
            {
                var updatedQueue = new Queue<int>(cache);

                if (value == endPoint)
                {
                    updatedQueue.Enqueue(value);

                    results.Add(updatedQueue);

                    continue;
                }

                if (updatedQueue.Contains(value))
                    continue;

                updatedQueue.Enqueue(value);

                CheckGraphElement(value, endPoint, updatedQueue);
            }
        }
    }
}