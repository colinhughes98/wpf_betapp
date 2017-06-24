using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixtures.Interfaces;
using Prism.Mvvm;

namespace Fixtures.ViewModels
{
    public class HelloWorldViewModel : BindableBase, IBaseViewModel
    {
        public readonly IBaseCommand Command;
        private NameModel _name = new NameModel();

        public HelloWorldViewModel(IBaseCommand command)
        {
            Command = command;
        }

        public NameModel Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        
    }

    public class NameModel : BindableBase
    {
        private string _name = "test";

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
