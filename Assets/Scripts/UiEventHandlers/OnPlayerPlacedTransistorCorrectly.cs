using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UiEventHandlers
{
    public class OnPlayerPlacedTransistorCorrectly : MonoBehaviour
    {
        [SerializeField]
        public UiEventsMessageBrokerTemplate UiEventsMessageBroker;

        private bool IsTransistorInTargetArea = false;

        public void OnTransistorPlaced()
        {
            if (IsTransistorInTargetArea)
            {
                UiEventsMessageBroker.PlayerPlacedTransistorCorrectly();
            }
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "TransistorTargetArea")
            {
                this.IsTransistorInTargetArea = true;
            }
        }

        public void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.name == "TransistorTargetArea")
            {
                this.IsTransistorInTargetArea = false;
            }
        }
    }
}
