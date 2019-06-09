using System.Collections;
using System.Collections.Generic;
using Lightningfall.UseCase;
using PropertyChanged;
using Reactive.Bindings;

namespace Lightningfall.App.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BacklogItemsViewModel
    {
        private readonly IManageProject _manageProject;

        private readonly ReactiveCollection<TaskViewModel> _tasks = new ReactiveCollection<TaskViewModel>();

        public ReadOnlyReactiveCollection<TaskViewModel> Tasks { get; }

        public BacklogItemsViewModel(IManageProject manageProject)
        {
            _manageProject = manageProject;
            Tasks = _tasks.ToReadOnlyReactiveCollection();

            foreach (var projectTask in _manageProject.Project.Tasks)
            {
                _tasks.Add(new TaskViewModel(projectTask));
            }
        }
    }
}