using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (player.position - transform.position) + offset;
        transform.position += dir * speed;
    }
}
