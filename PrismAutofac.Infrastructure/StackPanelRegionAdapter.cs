using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Regions;

namespace PrismAutofacApp.Infrastructure
{
    // This class is good to use for Stack small view in mudolue
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            throw new NotImplementedException();
        }

        protected override IRegion CreateRegion()
        {
            throw new NotImplementedException();
        }
    }
}
