using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AudioExtension
{
    public static class AudioHelper
    {
        public static void PlayRandomAudioFromList(List<AudioClip> audioClips, AudioSource audioSource)
        {
            audioSource.clip = audioClips[Random.Range(0, audioClips.Capacity)];
            audioSource.Play();
        }
 
    }

}
