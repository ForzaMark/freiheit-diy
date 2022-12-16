using UnityEngine;

public class OnTransistorGrabed : MonoBehaviour
{
    [SerializeField] GameObject TransistorTargetArea;

    private Color initialEndColor;

    private void Awake()
    {
        initialEndColor = TransistorTargetArea.GetComponent<BlinkEffect>().endColor;
    }

    public void OnTransistorSelected()
    {
        TransistorTargetArea.GetComponent<BlinkEffect>().enabled = true;
    }

    public void OnTransistorDropped()
    {
        TransistorTargetArea.GetComponent<BlinkEffect>().enabled = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        TransistorTargetArea.GetComponent<BlinkEffect>().endColor = TransistorTargetArea.GetComponent<BlinkEffect>().startColor;
    }

    public void OnCollisionExit(Collision collision)
    {
        var isBlinkEnabled = TransistorTargetArea.GetComponent<BlinkEffect>().enabled;

        if (isBlinkEnabled)
        {
            TransistorTargetArea.GetComponent<BlinkEffect>().endColor = initialEndColor;
        } else
        {
            TransistorTargetArea.GetComponent<BlinkEffect>().enabled = false;
        }
    }
}
