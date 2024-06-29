using GameComponentAttributes.Attributes;
using UnityEngine;
using UnityEngine.Audio;

namespace GameJamEntry.Global {
	public class AudioElements : MonoBehaviour {
		[NotNullReference] public AudioSource BgmPlayer;
		[NotNullReference] public AudioSource SfxPlayer;
		[NotNullReference] public AudioMixer  Mixer;
	}
}