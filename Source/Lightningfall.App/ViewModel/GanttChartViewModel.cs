using System.Collections.Generic;
using System.Linq;
using Infragistics.Controls.Schedules;
using Lightningfall.UseCase;
using PropertyChanged;
using Reactive.Bindings;

namespace Lightningfall.App.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class GanttChartViewModel
    {
        private readonly IManageProject _manageProject;

        public GanttChartViewModel(IManageProject manageProject)
        {
            _manageProject = manageProject;
            Parse(_manageProject.Project.ManagedScheduleTasks);
        }

        private void Parse(IEnumerable<ITask> tasks)
        {
            foreach (var task in tasks)
            {
                Tasks.Add(new GanttChartTaskViewModel(task));
                Parse(task.ManagedScheduleTasks);
            }
        }

        public ReactiveCollection<GanttChartTaskViewModel> Tasks { get; } = new ReactiveCollection<GanttChartTaskViewModel>();
    }
}