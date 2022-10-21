using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class GrabTestGameObject : State
    {
        public GrabTestGameObject(GameSystem gameSystem) : base(gameSystem, StateName.GrabTestGameObject) { }

        public override IEnumerator Execute()
        {
            GameSystem.AudioManager.PlayClipAsync(AudioClipNames.GrabAndMoveTestObjectAudioClip);

            GameSystem.UiEventsMessageBroker.ControlsTestObjectMovedEvent.AddListener(TestObjectMovedAction);
            yield break;
        }

        public override void Dispose()
        {
            GameSystem.UiEventsMessageBroker.ControlsTestObjectMovedEvent.RemoveListener(TestObjectMovedAction);
        }

        private void TestObjectMovedAction(bool value)
        {
            GameSystem.SetState(new FinishGameControlExplanation(GameSystem));
        }
    }
}
