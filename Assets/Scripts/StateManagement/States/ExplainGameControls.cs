using System.Collections;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class ExplainGameControls : State
    {
        public ExplainGameControls(GameSystem gameSystem) : base(gameSystem, StateName.ExplainGameControl) { }

        public override IEnumerator Execute()
        {
            GameSystem.ControlsTestObjectCube.SetActive(true);
            yield return GameSystem.AudioManager.PlayClipSync(AudioClipNames.MoveAndTargetTestObjectAudioClip);

            GameSystem.UiEventsMessageBroker.ControlsTestObjectHoveredEvent.AddListener(TestObjectHoveredAction);
            yield break;
        }

        private void TestObjectHoveredAction(bool value)
        {
            GameSystem.SetState(new GrabTestGameObject(GameSystem));
        }
    }
}
