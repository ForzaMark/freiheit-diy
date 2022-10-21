using System.Collections;
using Assets.Scripts;
using UnityEngine;

namespace Assets.StateManagement
{
    public class WalkToTable : State
    {
        public WalkToTable(GameSystem gameSystem) : base(gameSystem, StateName.WalkToTable) { }

        public override IEnumerator Execute()
        {
            GameSystem.UiEventsMessageBroker.PlayerArrivedAtTableEvent.AddListener(OnPlayerArrivedAtTableEvent);

            GameSystem.EnvironmentManager.ProvideTeleportationImplementation();

            yield break;
        }

        public override void Dispose()
        {
            GameSystem.UiEventsMessageBroker.PlayerArrivedAtTableEvent.RemoveListener(OnPlayerArrivedAtTableEvent);
        }

        public static void MovePlayerByTeleportation(GameObject xrOrigin)
        {
            xrOrigin.transform.eulerAngles = new Vector3(10, -28, -2);
            xrOrigin.transform.position = new Vector3(-10, 8, 9);
        }

        private void OnPlayerArrivedAtTableEvent(bool value)
        {
            GameSystem.AudioManager.PlayClipAsync(AudioClipNames.PlayerArrivedAtTableAudioClip);
            GameSystem.PlayerTablePositionColliderArea.SetActive(false);
            GameSystem.SetState(new ConverterConstruction(GameSystem));
        }  
    }
}
