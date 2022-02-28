using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable 
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponentInParent<Animator>();
    }

    public override void Activate()
    {
        Debug.Log("oPEN LE DOOR!");
        anim.SetBool("openDoor", !anim.GetBool("openDoor"));
    }
}
