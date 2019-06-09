using System.Linq;
using PropertyChanged;
using Reactive.Bindings;

namespace Lightningfall.App.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class TaskViewModel
    {
        private readonly ITask _task;
        private double _estimatedManHour;

        public TaskViewModel(ITask task)
        {
            _task = task;
            Name = _task.Name;
            _estimatedManHour = _task.EstimatedManHour;
            foreach (var innerTask in _task.Tasks)
            {
                Tasks.Add(new TaskViewModel(innerTask));
            }
        }

        public string Name { get; set; }

        public double EstimatedManHour
        {
            get =>
                Tasks.Any()
                    ? Tasks.Sum(x => x.EstimatedManHour)
                    : _estimatedManHour;
            set => _estimatedManHour = value;
        }

        public ReactiveCollection<TaskViewModel> Tasks { get; } = new ReactiveCollection<TaskViewModel>();
    }
}