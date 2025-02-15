using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutosplitterComponent.UI.Components
{
    public class AutosplitterComponentFactory : IComponentFactory
    {
        public string ComponentName => "Autosplitter Component";

        public string Description => "Component based autosplitter";

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => ComponentName;

        public string XMLURL => String.Empty;

        public string UpdateURL => String.Empty;

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public IComponent Create(LiveSplitState state) => new AutosplitterComponent(state);
    }
}
