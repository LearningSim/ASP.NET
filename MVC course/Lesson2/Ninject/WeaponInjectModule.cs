using Castle;
using Ninject.Modules;

namespace Ninject {
	public class WeaponInjectModule : NinjectModule {
		public override void Load() {
			Bind<IWeapon>().To<Sword>();
		}
	}
}