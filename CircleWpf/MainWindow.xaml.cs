using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CircleWpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private CircleController MvcCircle = new CircleController();
		public MainWindow()
		{
			InitializeComponent();
			MvcCircle.Observers += OnRadiusChanged;
			MvcCircle.Radius = 100;
		}

		private void OnRadiusChanged(Object sender, EventArgs args)
		{
			Circle.Height = MvcCircle.Radius * 2;
			Circle.Width = MvcCircle.Radius * 2;
			tbRadius.Text = MvcCircle.Radius.ToString();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (Single.TryParse(tbRadius.Text, out float radius))
			{
				MvcCircle.Radius = radius;
			}
		}
	}
}
