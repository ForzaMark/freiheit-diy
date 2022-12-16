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

    public class AudioClipWithSpeed
    {
        public AudioClip AudioClip;
        public float Speed;

        public AudioClipWithSpeed(AudioClip audioClip, float speed = 1)
        {
            AudioClip = audioClip;
            Speed = speed;
        }
    }

    public class AudioManager
    {
        private readonly Dictionary<AudioClipNames, AudioClipWithSpeed> ClipConfiguration;
        private readonly AudioSource AudioSource;

        public AudioManager(Dictionary<AudioClipNames, AudioClipWithSpeed> configuration, AudioSource audioSource) {
            ClipConfiguration = configuration;
            AudioSource = audioSource;
        }

        public IEnumerator PlayClipSync(AudioClipNames audioClipName)
        {
            var audioClip = GetAudioClip(audioClipName);
            AudioSource.clip = audioClip.AudioClip;
            AudioSource.pitch = audioClip.Speed;
            AudioSource.Play();

            yield return new WaitForSeconds(AudioSource.clip.length / audioClip.Speed);
        }

        public void PlayClipAsync(AudioClipNames audioClipName)
        {
            var audioClip = GetAudioClip(audioClipName);
            AudioSource.clip = audioClip.AudioClip;
            AudioSource.Play();
        }

        private AudioClipWithSpeed GetAudioClip(AudioClipNames audioClipName) 
        {
            if(ClipConfiguration.TryGetValue(audioClipName, out var value)) 
            { 
                return value;
            } else
            {
                throw new Exception($"Unable to get the specified audioClipName <{audioClipName}> from the configuration");
            }
        }
    }
}
