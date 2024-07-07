using Game.Global.Sound;
using Game.Utils.UI;
using GameComponentAttributes.Attributes;
using Modules.FullscreenCanvasController;
using UnityEngine;

namespace Game.MainMenu.UI.GameSettings {
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