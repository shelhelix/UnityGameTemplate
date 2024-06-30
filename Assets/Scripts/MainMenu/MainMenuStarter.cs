using System.Collections.Generic;
using GameComponentAttributes.Attributes;
using GameJamEntry.Scripts.MainMenu.UI;
using Modules.Audio;
using UnityEngine;
using VContainer;

namespace GameJamEntry.Scripts.MainMenu {

	public class MainMenuStarter : MonoBehaviour {
		[NotNullReference] [SerializeField] List<AudioClip> Bgms;

		[Inject]
		public void Init(MainMenuScreenHelper mainMenuScreenManager, BgmManager bgmManager) {
			mainMenuScreenManager.ShowMainMenuScreen();
			bgmManager.PlayBgms(Bgms);
		}
	}
}