using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "UiEventsMessageBroker", menuName = "UiEventsMessageBroker")]
public class UiEventsMessageBrokerTemplate : ScriptableObject
{
    [HideInInspector]
    public UnityEvent<bool> ControlsTestObjectHoveredEvent;

    [HideInInspector]
    public UnityEvent<bool> ControlsTestObjectMovedEvent;

    [HideInInspector]
    public UnityEvent<bool> PlayerArrivedAtTableEvent;

    [HideInInspector]
    public UnityEvent<bool> PlayerPlacedTransistorCorrectlyEvent;

    public void ControlsTestObjectHovered()
    {
        ControlsTestObjectHoveredEvent.Invoke(true);
    }

    public void ControlsTestObjectMoved()
    {
        ControlsTestObjectMovedEvent.Invoke(true);
    }

    public void PlayerArrivedAtTable()
    {
        PlayerArrivedAtTableEvent.Invoke(true);
    }

    public void PlayerPlacedTransistorCorrectly()
    {
        PlayerPlacedTransistorCorrectlyEvent.Invoke(true);
    }

    private void OnEnable()
    {
        if (ControlsTestObjectHoveredEvent == null)
        {
            ControlsTestObjectHoveredEvent = new UnityEvent<bool>();
        }

        if (ControlsTestObjectMovedEvent == null)
        {
            ControlsTestObjectMovedEvent = new UnityEvent<bool>();
        }

        if (PlayerArrivedAtTableEvent == null)
        {
            PlayerArrivedAtTableEvent = new UnityEvent<bool>();
        }

        if (PlayerPlacedTransistorCorrectlyEvent == null)
        {
            PlayerPlacedTransistorCorrectlyEvent = new UnityEvent<bool>();
        }
    }
}
