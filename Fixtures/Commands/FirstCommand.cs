using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Fixtures.Interfaces;

namespace Fixtures.Commands
{
    public class FirstCommand : IBaseCommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //
        }

        public event EventHandler CanExecuteChanged;
    }
}
