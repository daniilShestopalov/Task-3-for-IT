using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task_3
{
    internal class ShapeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> ShapeTypes { get; set; }
        public ICommand LoadAssemblyCommand { get; set; }

        public ShapeViewModel()
        {
            ShapeTypes = new ObservableCollection<string>();
            LoadAssemblyCommand = new RelayCommand(LoadAssembly);
        }

        public void LoadAssembly(string path)
        {
            var assembly = Assembly.LoadFrom(path);
            var types = assembly.GetTypes().Where(t => typeof(InterfaceShape).IsAssignableFrom(t) && !t.IsInterface);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class RelayCommand : ICommand
        {
            private readonly Action<object> execute;
            private readonly Func<object, bool> canExecute;

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
            {
                this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
                this.canExecute = canExecute;
            }

            public bool CanExecute(object parameter) => this.canExecute == null || this.canExecute(parameter);

            public void Execute(object parameter) => this.execute(parameter);
        }
    }
}
