using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWpf
{
	public class CircleController
	{
		private Models.Circle Circle { get; } = new Models.Circle();

		public float Radius
		{
			get => Circle.Radius;
			set
			{
				if (value > 0)
				{
					Circle.Radius = value;
				}
			}
		}

		public event Pattern.Observable.NotifyHandler Observers
		{
			add
			{
				Circle.Observers += value;
			}
			remove
			{
				Circle.Observers -= value;
			}
		}
	}
}
