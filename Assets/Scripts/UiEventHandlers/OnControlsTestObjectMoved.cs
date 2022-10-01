using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnControlsTestObjectMoved : MonoBehaviour
{
    [SerializeField]
    public UiEventsMessageBrokerTemplate UiEventsMessageBroker;

    public void OnControlsTestObjectMove()
    {
        UiEventsMessageBroker.ControlsTestObjectMoved();
    }
}
