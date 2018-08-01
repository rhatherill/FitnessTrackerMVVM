using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using BasicRegionNavigation.Views;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

namespace BasicRegionNavigation.PRISM_bits
{
    class PrismModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public PrismModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        //Add views to the catalog for navigation
        public void Initialize()
        {
            _container.RegisterTypeForNavigation<AddUserView>();
            _container.RegisterTypeForNavigation<EnterWeightView>();
            _container.RegisterTypeForNavigation<TrackWeightView>();
            _container.RegisterTypeForNavigation<CalculateExerciseView>();
        }
    }
}
