using System.Collections;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class WalkToTable : State
    {
        public WalkToTable(GameSystem gameSystem) : base(gameSystem, StateName.WalkToTable) { }

        public override IEnumerator Execute()
        {
            GameSystem.UiEventsMessageBroker.PlayerArrivedAtTableEvent.AddListener(OnPlayerArrivedAtTableEvent);
            yield break;
        }

        public override void Dispose()
        {
            GameSystem.UiEventsMessageBroker.PlayerArrivedAtTableEvent.RemoveListener(OnPlayerArrivedAtTableEvent);
        }

        private void OnPlayerArrivedAtTableEvent(bool value)
        {
            GameSystem.AudioManager.PlayClipAsync(AudioClipNames.PlayerArrivedAtTableAudioClip);
            GameSystem.PlayerTablePositionColliderArea.SetActive(false);
            GameSystem.SetState(new ConverterConstruction(GameSystem));
        }  
    }
}
