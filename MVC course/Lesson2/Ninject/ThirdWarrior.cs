using Castle;

namespace Ninject {
	public class ThirdWarrior {
		[Inject]
		public IWeapon Weapon { get; set; }

		public void Kill() {
			Weapon.Kill();
		}
	}
}