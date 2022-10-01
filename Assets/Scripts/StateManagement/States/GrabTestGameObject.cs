using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class GrabTestGameObject : State
    {
        public GrabTestGameObject(GameSystem gameSystem) : base(gameSystem) { }

        public override IEnumerator Execute()
        {
            GameSystem.AudioManager.PlayClipSync(AudioClipNames.GrabAndMoveTestObjectAudioClip);

            GameSystem.UiEventsMessageBroker.ControlsTestObjectMovedEvent.AddListener(TestObjectMovedAction);
            yield break;
        }

        private void TestObjectMovedAction(bool value)
        {
            GameSystem.SetState(new FinishGameControlExplanation(GameSystem));
        }
    }
}
