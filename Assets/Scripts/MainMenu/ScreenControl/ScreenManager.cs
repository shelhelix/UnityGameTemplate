using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.UI;
using GameJamEntry.MainMenu.UI.Settings;
using UnityEngine;

namespace GameJamEntry.MainMenu.ScreenControl {
	public class ScreenManager : MonoBehaviour {
		[NotNullReference] [SerializeField] MainMenuScreen MainScreen;
		[NotNullReference] [SerializeField] SettingsScreen SettingsScreen;

		List<BaseScreen> _allScreens;

		bool _inTransit;
		
		public void Init() {
			_allScreens = new List<BaseScreen> {
				MainScreen,
				SettingsScreen,
			};
			_allScreens.ForEach(FirstInit);
		}

		public void Deinit() {
			
		}

		public async UniTaskVoid ShowScreen<T>(Action<T> initAction = null) where T : BaseScreen {
			if ( _inTransit ) {
				return;
			}
			if ( _allScreens.Find(x => x is T) is not T neededScreen ) {
				return;
			}
			_inTransit = true;
			var hideTasks = _allScreens.Select(x => x.Hide());
			await UniTask.WhenAll(hideTasks);
			initAction?.Invoke(neededScreen);
			await neededScreen.Show();
			_inTransit = false;
		}

		void FirstInit(BaseScreen screen) {
			screen.gameObject.SetActive(true);
			screen.CanvasGroup.alpha          = 0;
			screen.CanvasGroup.blocksRaycasts = false;
		}
	}
}