using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePosition : MonoBehaviour
{
    void Update()
    {
        transform.localPosition = new Vector3(0,0,0);
        transform.localRotation = new Quaternion(0, 0, 0, 0);
    }
}
