﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField]
    float dashSpeed, dashTime, coolDown;
    [SerializeField, Header("Destroy objects")]
    float radius;
    [SerializeField]
    LayerMask destructionLayer;

    bool canDash;
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
        if (Input.GetKeyDown(KeyCode.E) && Time.time > timer) StartCoroutine(Addvelocity());

        if (canDash)
        {
            DestroyObjects();
            pm.Movement((transform.forward * dashSpeed));
        }
    }

    void DestroyObjects()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radius, destructionLayer);
        foreach (Collider col in cols)
        {
            Destroy(col.gameObject);
            canDash = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    IEnumerator Addvelocity()
    {
        canDash = true;
        yield return new WaitForSeconds(dashTime);
        rb.velocity = Vector3.zero;
        canDash = false;
        timer = Time.time + coolDown;
    }
}
