using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTeleport : MonoBehaviour
{
    public Transform spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CharacterController controller = other.GetComponent<CharacterController>();
            controller.enabled = false;
            other.transform.position = spawnPoint.position;
            controller.enabled = true;
        }
    }

}
