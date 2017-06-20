using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace Fixtures
{
    public class FixturesModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public FixturesModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorld));
        }
    }
}
