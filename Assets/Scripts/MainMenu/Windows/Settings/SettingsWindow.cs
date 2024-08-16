using Com.Shelinc.Windows;
using Cysharp.Threading.Tasks;
using Game.Global.Sound;
using Game.Utils.UI;
using GameComponentAttributes.Attributes;
using VContainer;

namespace Game.MainMenu.UI.GameSettings {
	public class SettingsWindow : BaseWindow {
		[NotNullReference] public ButtonWrapper      ReturnButton;
		[NotNullReference] public SoundSettingView masterSettingViews;
		[NotNullReference] public SoundSettingView musicSettingViews;
		[NotNullReference] public SoundSettingView sfxSettingViews;
		
		public static IShowRequest CreateShowRequest() => new NoParamsShowRequest<SettingsWindow>();
		
		[Inject]
		public void Init(SoundSettingsController settingsController) {
			ReturnButton.RemoveAllAndAddListener(() => Hide().Forget());
			masterSettingViews.Init(settingsController, MixerParamName.MasterVolume);
			musicSettingViews.Init(settingsController, MixerParamName.MusicVolume);
			sfxSettingViews.Init(settingsController, MixerParamName.SfxVolume);
		}
	}
}