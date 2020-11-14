using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;

    Rigidbody rb;
    Ray ray;

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
            if (Input.GetKeyDown(KeyCode.Space) && hit.distance < 0.6f)
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);



    }
}
