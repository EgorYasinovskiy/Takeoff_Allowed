using System;
using System.Collections.Generic;
using System.Text;
using TakeoffAllowed.Model.Sctructs;

namespace TakeoffAllowed.Model.GameObjects
{
	class PawnAirplane : Airplane
	{
		public PawnAirplane(double velocity, PointF3D location, Vector3D direction) : base(velocity, location, direction)
		{
		}




		#region Airplane movement logic
		// Lower height for landing or to avoid collision.
		public void Decline()
		{
			throw new NotImplementedException("Impliment declining method.");
		}
		// Raise height for takeoff, second landing circle or to avoid collisions .
		public void RaiseUp()
		{
			throw new NotImplementedException("Impliment climbing method.");
		}
		// Turn aside to avoid collisions.
		public void TurnAside()
		{
			throw new NotImplementedException("Impliment pivot method.");
		}
		#endregion

	}
}
