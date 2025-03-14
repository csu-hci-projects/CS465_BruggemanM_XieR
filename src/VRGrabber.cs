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

//Makes an object grabable in VR by using XRGrabInteractable which is the built-in Unity XR command for handling VR Interactions. 
//It then automatically assigns the XRGrabInteractable element right when the script starts.
//Attach this script to any VR object and it will make it grabbable. 
