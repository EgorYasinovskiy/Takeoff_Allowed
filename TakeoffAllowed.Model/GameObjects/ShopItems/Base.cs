using System;
using System.Collections.Generic;
using System.Text;

namespace TakeoffAllowed.Model.GameObjects.ShopItems
{
	public abstract class Base
	{
		public int Price { get; private set; }
		public string Name { get; private set; }
		
		// Maybe some more fields in future
		public bool CanBuy()
		{
			//The method will have to take into account previous purchases and the amount of the player's money. Solution options:
			//1 - Come up with a model that stores this data and pass it to the method.
			//2 - Add a delegate to the class, implementing which for each specific model we will issue the corresponding value.
			throw new NotImplementedException();
			
	}

	}
}
