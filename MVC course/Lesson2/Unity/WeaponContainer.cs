using Castle;

namespace Unity {
	public class WeaponContainer : UnityContainer {
		public WeaponContainer() {
			this.RegisterType<IWeapon, Bazooka>();
		}
	}
}