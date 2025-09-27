using TriInspector;
using UnityEngine;
using UnityEngine.Audio;

namespace Com.Shelinc.GlobalAudio.Modules.GlobalAudio {
	public class AudioElements : MonoBehaviour {
		[Required] public AudioSource BgmPlayer;
		[Required] public AudioSource SfxPlayer;
		[Required] public AudioMixer  Mixer;
	}
}