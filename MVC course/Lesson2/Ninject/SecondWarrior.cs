using Castle;

namespace Ninject {
	public class SecondWarrior {
		private IWeapon weapon;

		public IWeapon Weapon {
			get { return weapon ?? (weapon = Program.AppKernel.Get<IWeapon>()); }
		}

		public void Kill() {
			Weapon.Kill();
		}
	}
}