using System;
using PropertyChanged;

namespace Lightningfall.App.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class WorkResultViewModel
    {
        public TimeSpan WorkTime { get; set; }
    }
}