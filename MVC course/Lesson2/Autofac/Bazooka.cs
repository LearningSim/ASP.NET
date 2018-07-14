using System;

namespace Castle {
	public class Bazooka : IWeapon {
		public void Kill() {
			Console.WriteLine("BIG BADABUM!");
		}
	}
}