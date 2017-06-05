using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetGameAudioVol : MonoBehaviour 
{

	public AudioMixer mainMixer;					//Used to hold a reference to the AudioMixer mainMixer


	//Call this function and pass in the float parameter musicLvl to set the volume of the AudioMixerGroup Music in mainMixer
	public void SetMusicLevel(float musicLvl)
	{
		mainMixer.SetFloat("Game_Music_Vol", musicLvl);
	}

	//Call this function and pass in the float parameter sfxLevel to set the volume of the AudioMixerGroup SoundFx in mainMixer
	public void SetSfxLevel(float sfxLevel)
	{
		mainMixer.SetFloat("Game_SFX_Vol", sfxLevel);
	}

	public void SetMasterLevel(float masterLevel)
	{
		mainMixer.SetFloat("Game_Master_Vol", masterLevel);
	}

}
