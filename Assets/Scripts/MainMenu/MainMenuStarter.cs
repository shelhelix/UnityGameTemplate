using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.MainMenu.UI;

namespace GameJamEntry.MainMenu {
	public class MainMenuStarter : GameComponent {
		[NotNull] public ScreenManager ScreenManager;
			
		protected void Start() {
			ScreenManager.Init();
			ScreenManager.ShowScreen<MainMenuScreen>(x => x.Init(ScreenManager)).Forget();
		}
	}
}