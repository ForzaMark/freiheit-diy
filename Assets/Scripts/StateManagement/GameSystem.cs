using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.Video;

namespace Assets.StateManagement
{
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

        [HideInInspector]
        public AudioSource AudioSource;

        [HideInInspector]
        public AudioManager AudioManager;

        private void Start()
        {
            AudioSource = GetComponent<AudioSource>();
            AudioManager = new AudioManager(new Dictionary<AudioClipNames, AudioClip>
            {
                { AudioClipNames.InitialStoryAudioClip, InitialStoryAudioClip },
                { AudioClipNames.MoveAndTargetTestObjectAudioClip, MoveAndTargetTestObjectAudioClip },
                { AudioClipNames.GrabAndMoveTestObjectAudioClip, GrabAndMoveTestObjectAudioClip },
                { AudioClipNames.FinishControlsExplanationAudioClip, FinishGameControlExplanationAudioClip },
                { AudioClipNames.PlayerArrivedAtTableAudioClip, PlayerArrivedAtTableAudioClip },
                { AudioClipNames.PlayerPlacedTransistorCorrectlyAudioClip, PlayerPlacedTransistorCorrectlyAudioClip }
            }, AudioSource);
            SetState(new ExplainInitialStory(this));
        }
    }
}
