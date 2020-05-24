using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private void Update()
    {
        Vector3 posPlayer = PlayerController.sharedInstance.transform.position;
        transform.position = new Vector3(posPlayer.x, 0);
    }
}
