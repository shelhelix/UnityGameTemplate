using Game.Global.Sound;
using Game.Utils.UI;
using GameComponentAttributes.Attributes;
using Modules.FullscreenCanvasController;

namespace Game.MainMenu.UI.GameSettings {
	public class SettingsScreen : BaseScreen {
		[NotNullReference] public ButtonWrapper      ReturnButton;
		[NotNullReference] public SoundSettingsBlock MasterSettingsBlocks;
		[NotNullReference] public SoundSettingsBlock MusicSettingsBlocks;
		[NotNullReference] public SoundSettingsBlock SfxSettingsBlocks;
		
		public void Init(MainMenuScreenHelper helper, SoundSettingsController settingsController) {
			ReturnButton.RemoveAllAndAddListener(helper.ShowMainMenuScreen);
			MasterSettingsBlocks.Init(settingsController, MixerParamName.MasterVolume);
			MusicSettingsBlocks.Init(settingsController, MixerParamName.MusicVolume);
			SfxSettingsBlocks.Init(settingsController, MixerParamName.SfxVolume);
		}
	}
}