using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class GrabFunkamateurMagazine : XRGrabInteractable
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
        if (hasAttached)
        {
            interactor.attachTransform.position = new Vector3(attachTransform.position.x + 1, attachTransform.position.y + 2, attachTransform.position.z - 5);
        }
        else
        {
            interactor.attachTransform.position = transform.position;
        }
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
