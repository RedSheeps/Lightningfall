using System.Windows;
using System.Windows.Input;
namespace RedSheeps.Wpf.Interactivity {

	#region Infragistics.Controls.Schedules.XamGantt
	public static partial class XamGanttBehavior {

        public static readonly DependencyProperty CellChangedProperty =
            DependencyProperty.RegisterAttached("CellChanged", typeof(ICommand), typeof(Infragistics.Controls.Schedules.XamGantt), new FrameworkPropertyMetadata(OnCellChangedChanged));
        
        public static ICommand GetCellChanged(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellChangedProperty);
        }
        
        public static void SetCellChanged(DependencyObject target, ICommand value)
        {
            target.SetValue(CellChangedProperty, value);
        }
        
        private static void OnCellChangedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Infragistics.Controls.Schedules.XamGantt target)
            {
                if (e.OldValue != null)
                {
                    target.CellChanged -= OnCellChanged;
                }
                if (e.NewValue != null)
                {
                    target.CellChanged += OnCellChanged;
                }
            }
        }
        
        private static void OnCellChanged(object o, Infragistics.Controls.Schedules.GanttGridCellChangedEventArgs eventArgs)
        {
			var commandParameter = eventArgs;
            var command = GetCellChanged((DependencyObject)o);
            if (command.CanExecute(commandParameter))
                command.Execute(commandParameter);
        }

        public static readonly DependencyProperty CellChangedNotifyCellProperty =
            DependencyProperty.RegisterAttached("CellChanged", typeof(ICommand), typeof(Infragistics.Controls.Schedules.XamGantt), new FrameworkPropertyMetadata(OnCellChangedNotifyCellChanged));
        
        public static ICommand GetCellChangedNotifyCell(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellChangedNotifyCellProperty);
        }
        
        public static void SetCellChangedNotifyCell(DependencyObject target, ICommand value)
        {
            target.SetValue(CellChangedNotifyCellProperty, value);
        }
        
        private static void OnCellChangedNotifyCellChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Infragistics.Controls.Schedules.XamGantt target)
            {
                if (e.OldValue != null)
                {
                    target.CellChanged -= OnCellChangedNotifyCell;
                }
                if (e.NewValue != null)
                {
                    target.CellChanged += OnCellChangedNotifyCell;
                }
            }
        }
        
        private static void OnCellChangedNotifyCell(object o, Infragistics.Controls.Schedules.GanttGridCellChangedEventArgs eventArgs)
        {
			var commandParameter = eventArgs.Cell;
            var command = GetCellChangedNotifyCell((DependencyObject)o);
            if (command.CanExecute(commandParameter))
                command.Execute(commandParameter);
        }

        public static readonly DependencyProperty CellChangedNotifyCellColumnProperty =
            DependencyProperty.RegisterAttached("CellChanged", typeof(ICommand), typeof(Infragistics.Controls.Schedules.XamGantt), new FrameworkPropertyMetadata(OnCellChangedNotifyCellColumnChanged));
        
        public static ICommand GetCellChangedNotifyCellColumn(DependencyObject target)
        {
            return (ICommand)target.GetValue(CellChangedNotifyCellColumnProperty);
        }
        
        public static void SetCellChangedNotifyCellColumn(DependencyObject target, ICommand value)
        {
            target.SetValue(CellChangedNotifyCellColumnProperty, value);
        }
        
        private static void OnCellChangedNotifyCellColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Infragistics.Controls.Schedules.XamGantt target)
            {
                if (e.OldValue != null)
                {
                    target.CellChanged -= OnCellChangedNotifyCellColumn;
                }
                if (e.NewValue != null)
                {
                    target.CellChanged += OnCellChangedNotifyCellColumn;
                }
            }
        }
        
        private static void OnCellChangedNotifyCellColumn(object o, Infragistics.Controls.Schedules.GanttGridCellChangedEventArgs eventArgs)
        {
			var commandParameter = eventArgs.Cell.Column;
            var command = GetCellChangedNotifyCellColumn((DependencyObject)o);
            if (command.CanExecute(commandParameter))
                command.Execute(commandParameter);
        }

        public static readonly DependencyProperty DragEnterProperty =
            DependencyProperty.RegisterAttached("DragEnter", typeof(ICommand), typeof(Infragistics.Controls.Schedules.XamGantt), new FrameworkPropertyMetadata(OnDragEnterChanged));
        
        public static ICommand GetDragEnter(DependencyObject target)
        {
            return (ICommand)target.GetValue(DragEnterProperty);
        }
        
        public static void SetDragEnter(DependencyObject target, ICommand value)
        {
            target.SetValue(DragEnterProperty, value);
        }
        
        private static void OnDragEnterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Infragistics.Controls.Schedules.XamGantt target)
            {
                if (e.OldValue != null)
                {
                    target.DragEnter -= OnDragEnter;
                }
                if (e.NewValue != null)
                {
                    target.DragEnter += OnDragEnter;
                }
            }
        }
        
        private static void OnDragEnter(object o, System.Windows.DragEventArgs eventArgs)
        {
			var commandParameter = eventArgs;
            var command = GetDragEnter((DependencyObject)o);
            if (command.CanExecute(commandParameter))
                command.Execute(commandParameter);
        }
	}
	#endregion
}

