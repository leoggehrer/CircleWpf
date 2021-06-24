using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWpf.Models
{
	public class Circle : Pattern.Observable
	{
		private float radius;

		public float Radius 
		{ 
			get => radius;
			set
			{
				if (value > 0)
				{
					radius = value;
					NotifyAll();
				}
			}
		}
	}
}
