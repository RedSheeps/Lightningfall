using System.Collections;
using System.Collections.Generic;

namespace Lightningfall
{
    public interface ITask
    {
        int TaskId { get; }
        string Name { get; }

        double EstimatedManHour { get; set; }

        bool IsManagedSchedule { get; set; }

        IReadOnlyList<ITask> Tasks { get; }

        IEnumerable<ITask> ManagedScheduleTasks { get; }

        void AddTask(ITask task);
    }
}