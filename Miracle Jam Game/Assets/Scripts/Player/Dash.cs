using System.Collections;
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

    void DestroyObjects()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radius, destructionLayer);
        foreach (Collider col in cols)
            Destroy(col.gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    IEnumerator Addvelocity()
    {
        pm.Movement((transform.forward * dashSpeed));
        DestroyObjects();
        yield return new WaitForSeconds(dashTime);
        rb.velocity = Vector3.zero;
        timer = Time.time + coolDown;
    }
}
