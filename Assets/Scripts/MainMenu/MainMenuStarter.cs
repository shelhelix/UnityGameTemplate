using System.Collections.Generic;
using Game.MainMenu.UI;
using GameComponentAttributes.Attributes;
using Modules.Audio;
using UnityEngine;
using VContainer;

namespace Game.MainMenu {
	public class MainMenuStarter : MonoBehaviour {
		[NotNullReference] public List<AudioClip> Bgms;

		[Inject]
		public void Init(MainMenuScreenHelper mainMenuScreenManager, BgmManager bgmManager) {
			mainMenuScreenManager.ShowMainMenuScreen();
			bgmManager.PlayBgms(Bgms);
		}
	}
}