using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lightningfall
{
    public class Task : ITask
    {
        private readonly List<ITask> _tasks = new List<ITask>();

        private static int _maxTaskId = 0;

        public Task(string name)
        {
            Name = name;
        }


        public int TaskId { get; } = _maxTaskId++;
        public string Name { get; }
        public double EstimatedManHour { get; set; }
        public bool IsManagedSchedule { get; set; }

        public IReadOnlyList<ITask> Tasks => _tasks;
        public IEnumerable<ITask> ManagedScheduleTasks => Tasks.Where(x => x.IsManagedSchedule);

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }
    }
}