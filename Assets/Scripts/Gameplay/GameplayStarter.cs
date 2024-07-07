using System.Collections.Generic;
using GameComponentAttributes.Attributes;
using Modules.Audio;
using UnityEngine;
using VContainer;

namespace Game.Gameplay {
	public class GameplayStarter : MonoBehaviour {
		[NotNullReference] [SerializeField] List<AudioClip> Bgms;

		[Inject]
		public void Init(BgmManager bgmManager) {
			bgmManager.PlayBgms(Bgms);
		}
	}
}