using System.Collections.Generic;
using GameComponentAttributes.Attributes;
using GameJamEntry.Global;
using UnityEngine;
using VContainer;

namespace GameJamEntry.Gameplay {
	public class GameplayStarter : MonoBehaviour {
		[NotNullReference] [SerializeField] List<AudioClip> Bgms;

		[Inject]
		public void Init(BgmManager bgmManager) {
			bgmManager.PlayBgms(Bgms);
		}
	}
}