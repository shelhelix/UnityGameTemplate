using System.Collections.Generic;
using Com.Shelinc.GlobalAudio.Modules.GlobalAudio;
using TriInspector;
using UnityEngine;
using VContainer;

namespace Game.GameplayScene {
	public class GameplayStarter : MonoBehaviour {
		[Required] public List<AudioClip> Bgms;

		[Inject]
		public void Init(BgmManager bgmManager) {
			bgmManager.PlayBgms(Bgms);
			
			
		}
	}
}