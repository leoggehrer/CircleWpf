using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWpf.Pattern
{
	public abstract class Observable
	{
		public delegate void NotifyHandler(Object sender, EventArgs args);


		public event NotifyHandler Observers;

		protected void NotifyAll()
		{
			Observers?.Invoke(this, EventArgs.Empty);
		}
	}
}
