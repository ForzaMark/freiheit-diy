using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.Scripts
{
    public enum AudioClipNames
    {
        InitialStoryAudioClip,
        MoveAndTargetTestObjectAudioClip,
        GrabAndMoveTestObjectAudioClip,
        FinishControlsExplanationAudioClip,
        PlayerArrivedAtTableAudioClip,
        PlayerPlacedTransistorCorrectlyAudioClip
    }

    public class AudioManager
    {
        private readonly Dictionary<AudioClipNames, AudioClip> ClipConfiguration;
        private readonly AudioSource AudioSource;

        public AudioManager(Dictionary<AudioClipNames, AudioClip> configuration, AudioSource audioSource) {
            ClipConfiguration = configuration;
            AudioSource = audioSource;
        }

        public IEnumerator PlayClipSync(AudioClipNames audioClipName, float speed = 1)
        {
            var audioClip = GetAudioClip(audioClipName);
            AudioSource.clip = audioClip;
            AudioSource.pitch = speed;
            AudioSource.Play();

            yield return new WaitForSeconds(AudioSource.clip.length / speed);
        }

        public void PlayClipAsync(AudioClipNames audioClipName)
        {
            var audioClip = GetAudioClip(audioClipName);
            AudioSource.clip = audioClip;
            AudioSource.Play();
        }

        private AudioClip GetAudioClip(AudioClipNames audioClipName) 
        {
            if(ClipConfiguration.TryGetValue(audioClipName, out var value)) {
                AudioSource.clip = value;
                AudioSource.Play();

                return value;
            } else
            {
                throw new Exception($"Unable to get the specified audioClipName <{audioClipName}> from the configuration");
            }
        }
    }
}
