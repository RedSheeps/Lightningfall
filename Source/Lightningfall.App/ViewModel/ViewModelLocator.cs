using System;

namespace Lightningfall.App.ViewModel
{
    public static class ViewModelLocator
    {
        public static IViewModelResolver ViewModelResolver { private get; set; }
        public static BacklogItemsViewModel BacklogItemsViewModel => ViewModelResolver.Resolve<BacklogItemsViewModel>();
        public static GanttChartViewModel GanttChartViewModel => ViewModelResolver.Resolve<GanttChartViewModel>();

        public interface IViewModelResolver
        {
            T Resolve<T>() where T : class;
        }
    }
}