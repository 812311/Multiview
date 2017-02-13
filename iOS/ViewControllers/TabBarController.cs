using System;
using UIKit;

namespace Multiview.iOS
{
	public partial class TabBarController : UITabBarController
	{
		public TabBarController(IntPtr handle) : base(handle)
		{
			TabBar.Items[0].Title = "Browse";
			TabBar.Items[1].Title = "About";
		}
	}
}
