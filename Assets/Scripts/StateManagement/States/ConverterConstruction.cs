using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class ConverterConstruction : State
    {
        public ConverterConstruction(GameSystem gameSystem) : base(gameSystem, StateName.ConverterConstruction) { }

        public override IEnumerator Execute()
        {
            GameSystem.UiEventsMessageBroker.PlayerPlacedTransistorCorrectlyEvent.AddListener(OnPlayerPlacedTransistorCorrectly);
            yield break;
        }

        public override void Dispose()
        {
            GameSystem.UiEventsMessageBroker.PlayerPlacedTransistorCorrectlyEvent.RemoveListener(OnPlayerPlacedTransistorCorrectly);
        }

        private void OnPlayerPlacedTransistorCorrectly(bool value) 
        {
            GameSystem.AudioManager.PlayClipAsync(AudioClipNames.PlayerPlacedTransistorCorrectlyAudioClip);

            GameSystem.Transistor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            var videoComponent = GameSystem.VideoScreen.GetComponent<VideoPlayer>();
            videoComponent.clip = GameSystem.CreditVideo;
            videoComponent.Play();
        }
    }
}
