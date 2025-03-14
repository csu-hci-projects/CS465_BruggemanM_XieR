using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRGrabber : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }
}
