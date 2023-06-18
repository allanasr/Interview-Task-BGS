using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioExtension;

namespace Collectable
{
    public class CollectCollectable : MonoBehaviour , ICollectable
    {
        [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
        [SerializeField] AudioSource audioSource;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }
        public void Collectable()
        {
            AudioHelper.PlayRandomAudioFromList(audioClips, audioSource);
            Destroy(gameObject, 0.2f);
        }

    }
}
