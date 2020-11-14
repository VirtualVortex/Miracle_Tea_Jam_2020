using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform checkPoint;

    private void MovetoCheckPoint() => transform.position = checkPoint.position + (Vector3.up * 1.5f);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Checkpoint"))
            checkPoint = other.transform;

        if (other.tag.Contains("Death"))
            MovetoCheckPoint();
    }
}
