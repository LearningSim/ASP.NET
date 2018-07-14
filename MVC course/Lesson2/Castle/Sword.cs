using System;

namespace Castle {
	public class Sword : IWeapon {
		public void Kill() {
			Console.WriteLine("Chuk-chuck");
		}
	}
}
