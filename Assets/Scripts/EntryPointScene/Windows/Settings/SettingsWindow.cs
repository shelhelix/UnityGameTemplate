using Com.Shelinc.WindowSystem.Modules.WindowSystem.Core;
using Com.Shelinc.WindowSystem.Modules.WindowSystem.Core.Implementation;
using Cysharp.Threading.Tasks;
using Game.GlobalContext.Sound;
using Game.Utils.UI;
using TriInspector;
using VContainer;

namespace Game.EntryPointScene.Windows.Settings {
	public class SettingsWindow : BaseWindow {
		[Required] public ButtonWrapper      ReturnButton;
		[Required] public SoundSettingView masterSettingViews;
		[Required] public SoundSettingView musicSettingViews;
		[Required] public SoundSettingView sfxSettingViews;
		
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