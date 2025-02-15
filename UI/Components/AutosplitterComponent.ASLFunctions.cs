using LiveSplit.ComponentUtil;
using LiveSplit.Web.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutosplitterComponent.UI.Components
{
	public partial class AutosplitterComponent : LiveSplit.UI.Components.IComponent
	{
		public void Startup()
		{
		}

		public void Init()
		{
		}

		public bool Update()
		{
			return false;
		}

		public bool Start()
		{
			return false;
		}

		public void OnStart()
		{
		}

		public bool IsLoading()
		{
			return false;
        }

		public TimeSpan? GameTime()
		{
			return null;
		}

		public bool Reset()
		{
			return false;
		}

		public void OnReset()
		{
		}

		public bool Split()
		{
			return false;
        }

		public void OnSplit()
		{
		}

        public void Exit()
        {
        }
        
		public void Shutdown()
		{
		}

	}
}
