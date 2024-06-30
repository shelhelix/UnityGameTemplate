using GameComponentAttributes.Attributes;
using UnityEngine;
using UnityEngine.Audio;

namespace Modules.Audio {
	public class AudioElements : MonoBehaviour {
		[NotNullReference] public AudioSource BgmPlayer;
		[NotNullReference] public AudioSource SfxPlayer;
		[NotNullReference] public AudioMixer  Mixer;
	}
}