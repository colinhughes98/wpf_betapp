using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixtures.Commands;
using Fixtures.Interfaces;
using Fixtures.ViewModels;
using Fixtures.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace Fixtures
{
    public class FixturesModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public FixturesModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void Initialize()
        {
           RegisterViewModels();
        }

        private void RegisterViewModels()
        {
            _container.RegisterType<IBaseCommand, FirstCommand>();
            _container.RegisterType<IBaseViewModel, HelloWorldViewModel>();

            _regionManager.RegisterViewWithRegion("MainRegion", typeof(HelloWorld));
       
        
        }
    }

   
}
