using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.Video;

namespace Assets.StateManagement
{
    public enum GameEnvironment
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
        public VideoClip CreditVideo;

        [SerializeField]
        public GameObject XROrigin;

        [SerializeField]
        public GameObject PlayerTablePositionColliderArea;

        [SerializeField]
        public GameEnvironment Environment;

        [SerializeField]
        public GameObject XrDeviceSimulator;

        [HideInInspector]
        public AudioSource AudioSource;

        [HideInInspector]
        public AudioManager AudioManager;

        [HideInInspector]
        public EnvironmentManager EnvironmentManager;

        private void Start()
        {
            EnvironmentManager = new EnvironmentManager(
                Environment, 
                XrDeviceSimulator,
                XROrigin,
                FinishGameControlExplanation.EnablePlayerMovement,
                WalkToTable.MovePlayerByTeleportation
            );

            AudioSource = GetComponent<AudioSource>();

            AudioManager = new AudioManager(new Dictionary<AudioClipNames, AudioClipWithSpeed>
            {
                { AudioClipNames.InitialStoryAudioClip, new AudioClipWithSpeed(InitialStoryAudioClip, EnvironmentManager.GetInitialStorySpeed() ) },
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
