using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioExtension;

namespace Player
{
    public class PlayerAudio : MonoBehaviour
    {

        [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
        [SerializeField] AudioSource audioSource;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }
        
        public void PlayFootsteps()
        {
            AudioHelper.PlayRandomAudioFromList(audioClips, audioSource);
        }
    }
}
