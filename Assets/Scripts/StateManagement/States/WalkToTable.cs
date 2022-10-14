using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts;

namespace Assets.StateManagement
{
    public class WalkToTable : State
    {
        public WalkToTable(GameSystem gameSystem) : base(gameSystem, StateName.WalkToTable) { }

        public override IEnumerator Execute()
        {
            // remove this teleportation dummy
            GameSystem.XROrigin.transform.eulerAngles = new Vector3(10, -28, -2);
            GameSystem.XROrigin.transform.position = new Vector3(-10, 8, 9);

            GameSystem.UiEventsMessageBroker.PlayerArrivedAtTableEvent.AddListener(OnPlayerArrivedAtTableEvent);
            yield break;
        }

        private void OnPlayerArrivedAtTableEvent(bool value)
        {
            GameSystem.AudioManager.PlayClipSync(AudioClipNames.PlayerArrivedAtTableAudioClip);
            GameSystem.PlayerTablePositionColliderArea.SetActive(false);
            GameSystem.SetState(new ConverterConstruction(GameSystem));
        }  
    }
}
