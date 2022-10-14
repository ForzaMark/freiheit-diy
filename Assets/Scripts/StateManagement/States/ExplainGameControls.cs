using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class ExplainGameControls : State
    {
        public ExplainGameControls(GameSystem gameSystem) : base(gameSystem, StateName.ExplainGameControl) { }

        public override IEnumerator Execute()
        {
            GameSystem.AudioManager.PlayClipSync(AudioClipNames.MoveAndTargetTestObjectAudioClip);
            GameSystem.ControlsTestObjectCube.SetActive(true);

            GameSystem.UiEventsMessageBroker.ControlsTestObjectHoveredEvent.AddListener(TestObjectHoveredAction);
            yield break;
        }

        private void TestObjectHoveredAction(bool value)
        {
            GameSystem.SetState(new GrabTestGameObject(GameSystem));
        }
    }
}
