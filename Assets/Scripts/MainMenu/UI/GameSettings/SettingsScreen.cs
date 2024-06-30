using Com.Shelinc.FullscreenCanvasController.Modules.FullscreenCanvasController;
using GameComponentAttributes.Attributes;
using GameJamEntry.Scripts.Global.Sound;
using GameJamEntry.Scripts.Utils.UI;
using UnityEngine;

namespace GameJamEntry.Scripts.MainMenu.UI.GameSettings {
	public class SettingsScreen : BaseScreen {
		[NotNullReference] [SerializeField] ButtonWrapper      ReturnButton;
		[NotNullReference] [SerializeField] SoundSettingsBlock MasterSettingsBlocks;
		[NotNullReference] [SerializeField] SoundSettingsBlock MusicSettingsBlocks;
		[NotNullReference] [SerializeField] SoundSettingsBlock SfxSettingsBlocks;
		
		public void Init(MainMenuScreenHelper helper, SoundSettingsController settingsController) {
			ReturnButton.RemoveAllAndAddListener(helper.ShowMainMenuScreen);
			MasterSettingsBlocks.Init(settingsController, MixerParamName.MasterVolume);
			MusicSettingsBlocks.Init(settingsController, MixerParamName.MusicVolume);
			SfxSettingsBlocks.Init(settingsController, MixerParamName.SfxVolume);
		}
	}
}