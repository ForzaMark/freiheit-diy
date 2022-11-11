using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class GrabFunkamateurMagazine : XRGrabInteractable
{
    [SerializeField]
    public GameObject RightHandAttachmentPoint;

    private Vector3 InteractorPosition = Vector3.zero;

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        StoreInteractor(interactor);
        //MatchAttachmentPoints(interactor);
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        InteractorPosition = interactor.attachTransform.localPosition;
    }

    private void MatchAttachmentPoints(XRBaseInteractor interactor)
    {
        bool hasAttached = attachTransform != null;
        Debug.Log(attachTransform.transform.name);
        if (hasAttached)
        {
            
            interactor.transform.position = RightHandAttachmentPoint.transform.position;

            Debug.Log(interactor.transform.position.x + " " + interactor.transform.position.y + " " + interactor.transform.position.z);
            Debug.Log(RightHandAttachmentPoint.transform.position.x + " " + RightHandAttachmentPoint.transform.position.y + " " + RightHandAttachmentPoint.transform.position.z);
            // interactor.attachTransform.position = new Vector3(RightHandAttachmentPoint.transform.position.x, RightHandAttachmentPoint.transform.position.y , RightHandAttachmentPoint.transform.position.z );
            // interactor.attachTransform.position = new Vector3(attachTransform.position.x + 1, attachTransform.position.y + 2, attachTransform.position.z - 5);
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
