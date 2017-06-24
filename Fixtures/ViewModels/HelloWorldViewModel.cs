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
        private NameModel _name2;
        private NameModel _name1;


        public HelloWorldViewModel(IBaseCommand command)
        {
            Command = command;
            Name1 = new NameModel { Name = "Name1" };
            Name2 = new NameModel { Name = "Name2" };
        }

        public NameModel Name1
        {
            get { return _name1; }
            set { SetProperty(ref _name1, value); }
        }
        public NameModel Name2
        {
            get { return _name2; }
            set { SetProperty(ref _name2, value); }
        }

    }

    public class NameModel : BindableBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
