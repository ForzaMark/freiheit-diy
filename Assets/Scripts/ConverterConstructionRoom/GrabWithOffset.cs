using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class GrabWithOffset : XRGrabInteractable
{
    private Vector3 InteractorPosition = Vector3.zero;

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        StoreInteractor(interactor);
        MatchAttachmentPoints(interactor);
    }  

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        InteractorPosition = interactor.attachTransform.localPosition;
    }

    private void MatchAttachmentPoints(XRBaseInteractor interactor)
    {
        bool hasAttached = attachTransform != null;
        interactor.attachTransform.position = hasAttached ? attachTransform.position : transform.position; 
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
        ResetAttachmentPoints(interactor);
        ClearInteractor();
    }
    
    private void ResetAttachmentPoints(XRBaseInteractor interactor) 
    {
        interactor.attachTransform.localPosition = InteractorPosition;
    }

    private void ClearInteractor()
    {
        InteractorPosition = Vector3.zero;
    }
}
