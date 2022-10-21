using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.Video;

namespace Assets.StateManagement
{
    public enum Environment
    {
        LocalDevelopmentWithMockHeadset,
        LocalDevelopmentWithVRHeadset,
        Production
    }

    [RequireComponent(typeof(AudioSource))]
    public class GameSystem : StateMachine
    {
        [SerializeField]
        public AudioClip InitialStoryAudioClip;

        [SerializeField]
        public AudioClip MoveAndTargetTestObjectAudioClip;

        [SerializeField]
        public AudioClip GrabAndMoveTestObjectAudioClip;

        [SerializeField]
        public AudioClip FinishGameControlExplanationAudioClip;

        [SerializeField]
        public AudioClip PlayerArrivedAtTableAudioClip;

        [SerializeField]
        public AudioClip PlayerPlacedTransistorCorrectlyAudioClip;

        [SerializeField]
        public GameObject ControlsTestObjectCube;

        [SerializeField]
        public UiEventsMessageBrokerTemplate UiEventsMessageBroker;

        [SerializeField]
        public GameObject Transistor;

        [SerializeField] 
        public GameObject VideoScreen;

        [SerializeField] 
        public VideoClip SuccessVideo;

        [SerializeField]
        public GameObject XROrigin;

        [SerializeField]
        public GameObject PlayerTablePositionColliderArea;

        [SerializeField]
        public Environment Environment;

        [SerializeField]
        public GameObject XrDeviceSimulator;

        [HideInInspector]
        public AudioSource AudioSource;

        [HideInInspector]
        public AudioManager AudioManager;

        private void Start()
        {
            var environmentManager = new EnvironmentManager(Environment, XrDeviceSimulator);

            AudioSource = GetComponent<AudioSource>();

            AudioManager = new AudioManager(new Dictionary<AudioClipNames, AudioClipWithSpeed>
            {
                { AudioClipNames.InitialStoryAudioClip, new AudioClipWithSpeed(InitialStoryAudioClip, environmentManager.GetInitialStorySpeed() ) },
                { AudioClipNames.MoveAndTargetTestObjectAudioClip, new AudioClipWithSpeed(MoveAndTargetTestObjectAudioClip) },
                { AudioClipNames.GrabAndMoveTestObjectAudioClip, new AudioClipWithSpeed(GrabAndMoveTestObjectAudioClip) },
                { AudioClipNames.FinishControlsExplanationAudioClip, new AudioClipWithSpeed(FinishGameControlExplanationAudioClip) },
                { AudioClipNames.PlayerArrivedAtTableAudioClip, new AudioClipWithSpeed(PlayerArrivedAtTableAudioClip) },
                { AudioClipNames.PlayerPlacedTransistorCorrectlyAudioClip, new AudioClipWithSpeed(PlayerPlacedTransistorCorrectlyAudioClip) }
            }, AudioSource);

            SetState(new ExplainInitialStory(this));
        }
    }
}
