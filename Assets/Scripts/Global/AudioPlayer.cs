using UnityEngine;
using VContainer;

namespace GameJamEntry.Global {
	public class AudioPlayer {
		AudioSource _sfxSource;
		AudioSource _bgmSource;
		
		[Inject]
		public void Init(AudioPlayerObjects audioPlayerObjects) {
			_sfxSource = audioPlayerObjects.SfxPlayer;
			_bgmSource = audioPlayerObjects.BgmPlayer;
		}
		
		public void PlaySfx(AudioClip clip) {
			_sfxSource.PlayOneShot(clip);
		}
		
		public void PlayBgm(AudioClip clip) {
			_bgmSource.clip = clip;
			_bgmSource.loop = true;
			_bgmSource.Play();
		}
	}
}