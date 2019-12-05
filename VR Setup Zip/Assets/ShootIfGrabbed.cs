using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootIfGrabbed : MonoBehaviour
{
    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrGrabbale;
    public OVRInput.Button shootingButton;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot = GetComponent<SimpleShoot>();
        ovrGrabbale = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ovrGrabbale.isGrabbed && OVRInput.GetDown(shootingButton,ovrGrabbale.grabbedBy.GetController()))
        {
            //Shoot
            simpleShoot.TriggerShoot();
        }
    }
}
