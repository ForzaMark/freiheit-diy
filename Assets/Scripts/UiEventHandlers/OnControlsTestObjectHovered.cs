using UnityEngine;

public class OnControlsTestObjectHovered : MonoBehaviour
{
    [SerializeField]
    public UiEventsMessageBrokerTemplate UiEventsMessageBroker;

    public void OnControlsTestObjectHover()
    {
        UiEventsMessageBroker.ControlsTestObjectHovered();
    }
}
