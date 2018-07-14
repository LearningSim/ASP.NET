using Castle;
using CommonServiceLocator;

namespace Unity {
	public class SecondWarrior {
		private IWeapon weapon;

		public IWeapon Weapon {
			get { return weapon ?? (weapon = ServiceLocator.Current.GetInstance<IWeapon>()); }
		}

		public void Kill() {
			Weapon.Kill();
		}
	}
}