using System;
using TakeoffAllowed.Model.Sctructs;

namespace TakeoffAllowed.Model.GameObjects
{
	public abstract class Airplane
	{
		private double _velocity;
		private PointF3D _location;
		private Vector3D _direction;
		private Guid _guid;
		
		public double Velocity => _velocity;
		public PointF3D Location => _location;
		public Vector3D Direction => _direction;
		public Guid Guid => _guid;

		public Airplane(double velocity, PointF3D location, Vector3D direction)
		{
			_velocity = velocity;
			_location = location;
			_direction = direction;
			_guid = Guid.NewGuid();
		}
	}
}
