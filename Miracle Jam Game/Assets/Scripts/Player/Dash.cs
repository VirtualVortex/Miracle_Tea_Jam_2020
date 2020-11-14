using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField]
    float dashSpeed, dashTime, coolDown;

    float timer;
    Rigidbody rb;
    PlayerMovement pm;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > timer) StartCoroutine(Addvelocity());
    }

    IEnumerator Addvelocity()
    {
        pm.Movement((transform.forward * dashSpeed));
        yield return new WaitForSeconds(dashTime);
        rb.velocity = Vector3.zero;
        timer = Time.time + coolDown;
    }
}
