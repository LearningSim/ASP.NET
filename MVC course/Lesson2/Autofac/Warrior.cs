namespace Castle {
	public class Warrior {
		private readonly IWeapon weapon;

		public Warrior(IWeapon weapon) {
			this.weapon = weapon;
		}

		public void Kill() {
			weapon.Kill();
		}
	}
}