using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace GameJamEntry.MainMenu.UI {
	public class SettingsScreen : BaseScreen {
		[NotNull] [SerializeField] Button ReturnButton;

		ScreenManager _screenManager;
		
		public void Init(ScreenManager manager) {
			_screenManager = manager;
			ReturnButton.RemoveAllAndAddListener(ShowMainMenu);
		}

		void ShowMainMenu() {
			_screenManager.ShowScreen<MainMenuScreen>(x => x.Init(_screenManager)).Forget();
		}
	}
}