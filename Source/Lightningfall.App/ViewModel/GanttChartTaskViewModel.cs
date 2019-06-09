using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Infragistics.Controls.Schedules;
using PropertyChanged;
using Reactive.Bindings;

namespace Lightningfall.App.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class GanttChartTaskViewModel
    {
        private readonly ITask _task;
        private double _estimatedManHour;
        private IEnumerable<ITask> _tasks;

        public GanttChartTaskViewModel(ITask task)
        {
            _task = task;
            TaskId = _task.TaskId;
            Name = _task.Name;
            _estimatedManHour = _task.EstimatedManHour;
        }

        public int TaskId { get; set; }
        public string Name { get; set; }
        public ProjectDurationFormat DurationFormat { get; set; }
        public ProjectTaskConstraintType ConstraintType { get; set; }
        public DateTime? ConstraintDate { get; set; }
        public bool IsInProgress { get; set; } = true;

        public double EstimatedManHour
        {
            get =>
                _task.Tasks.Any()
                    ? _task.Tasks.Sum(x => x.EstimatedManHour)
                    : _estimatedManHour;
            set => _estimatedManHour = value;
        }

        public string Tasks
        {
            get => string.Join(", ", _task.ManagedScheduleTasks.Select(x => x.TaskId));
            set
            {
            }
        }
    }
}