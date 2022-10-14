using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionWithPlayerTablePosition : MonoBehaviour
{
    [SerializeField]
    public UiEventsMessageBrokerTemplate UiEventsMessageBroker;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerTablePositionColliderArea")
        {
            UiEventsMessageBroker.PlayerArrivedAtTable();
        }
    }
}
