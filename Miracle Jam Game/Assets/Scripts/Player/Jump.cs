using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;

    Rigidbody rb;
    Ray ray;

    [HideInInspector]
    public bool onGround;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.distance);

            if (Input.GetKeyDown(KeyCode.Space) && hit.distance < 1.1f)
            {
                transform.parent = null;
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
                onGround = false;
            }

            if (hit.distance < 1.1f)
                onGround = true;
        }
    }
}
