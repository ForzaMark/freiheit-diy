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
