using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class ConverterConstruction : State
    {
        public ConverterConstruction(GameSystem gameSystem) : base(gameSystem) { }

        public override IEnumerator Execute()
        {
            GameSystem.UiEventsMessageBroker.PlayerPlacedTransistorCorrectlyEvent.AddListener(OnPlayerPlacedTransistorCorrectly);
            yield break;
        }

        private void OnPlayerPlacedTransistorCorrectly(bool value) 
        {
            GameSystem.Transistor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            var videoComponent = GameSystem.VideoPlayer.GetComponent<VideoPlayer>();
            videoComponent.clip = GameSystem.SuccessVideo;
            GameSystem.AudioManager.PlayClipSync(AudioClipNames.PlayerPlacedTransistorCorrectlyAudioClip);
        }
    }
}
