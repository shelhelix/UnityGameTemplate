using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.MainMenu.UI;
using UnityEngine;

namespace GameJamEntry.MainMenu {
	public class MainMenuStarter : GameComponent {
		[NotNull] [SerializeField] ScreenManager ScreenManager;
		[NotNull] [SerializeField] SoundHelper   SoundHelper;

		SystemSettingsController SettingsController => GameState.Instance.SystemSettingsController;
		
		protected void Start() {
			ScreenManager.Init();
			SoundHelper.Init(SettingsController);
			ScreenManager.ShowScreen<MainMenuScreen>(x => x.Init(ScreenManager, SettingsController)).Forget();
		}

		protected void OnDestroy() {
			SoundHelper.Deinit();
		}
	}
}