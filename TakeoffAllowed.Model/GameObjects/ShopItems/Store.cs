using System;
using System.Collections.Generic;
using System.Text;

namespace TakeoffAllowed.Model.GameObjects.ShopItems
{
	public class Store
	{
		public List<AirportUpgrade> AirportUpgrades { get; set; }
		public List<PlayerUpgrade> PlayerUpgrades { get; set; }
		public List<Radar> Radars { get; set; }
		
		private Store()
		{
			AirportUpgrades = new List<AirportUpgrade>();
			PlayerUpgrades = new List<PlayerUpgrade>();
			Radars = new List<Radar>();
		}
		public static Store CreateNew()
		{
			return new Store();
		}
	}
}
