using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EmissionStates
{
    Switching,
    ShutDown,
    PermanentEnabled
}

public class AnimateTransistorTargetAreaOnTransistorGrabed : MonoBehaviour
{
    [SerializeField] GameObject TransistorTargetArea;

    private EmissionStates EmissionState = EmissionStates.ShutDown;
    private bool EnableEmission = false;

    public void OnTransistorSelected()
    {
        this.EmissionState = EmissionStates.Switching;
    }

    public void OnTransistorDropped()
    {
        this.EmissionState = EmissionStates.ShutDown;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TransistorTargetArea")
        {
            this.EmissionState = EmissionStates.PermanentEnabled;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "TransistorTargetArea")
        {
            this.EmissionState = this.EmissionState == EmissionStates.ShutDown ?
                                                       EmissionStates.ShutDown :
                                                       EmissionStates.Switching;
        }
    }

    public void Awake()
    {
        float duration = 0.2F;
        InvokeRepeating(nameof(HandleEmissionState), 0, duration);
    }

    private void HandleEmissionState()
    {
        if (this.EmissionState == EmissionStates.Switching)
        {
            if (this.EnableEmission)
            {
                var material = TransistorTargetArea.GetComponent<Renderer>().material;
                material.EnableKeyword("_EMISSION");
            }
            else
            {
                TransistorTargetArea.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            }
            this.EnableEmission = !this.EnableEmission;
        }


        if (this.EmissionState == EmissionStates.PermanentEnabled)
        {
            TransistorTargetArea.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }

        if (this.EmissionState == EmissionStates.ShutDown)
        {
            TransistorTargetArea.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
}
