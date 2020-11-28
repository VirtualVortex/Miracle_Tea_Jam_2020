using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    [HideInInspector]
    public Vector3 move;
    [HideInInspector]
    public Rigidbody rb;

    Camera cam;
    Animator anim;
    Jump jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        anim = GetComponentInChildren<Animator>();
        jump = GetComponent<Jump>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        Movement(Vector3.zero);
    }

    public void Movement(Vector3 externalValue)
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        move = (cam.transform.right * x + cam.transform.forward * z) + externalValue;
        move *= speed;
        move.y = rb.velocity.y;

        Rotate(x);

        //Player's movement
        if (x != 0f || z != 0f)
        {
            anim.SetFloat("MoveX", z);
            rb.velocity = move;
        }
    }

    //rotate player based on direction
    void Rotate(float x)
    {
        float angle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0, angle, 0);
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //Attach player to platform
        if (other.transform.tag.Contains("Platform"))
        {
            transform.SetParent(other.transform, true);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        //Dettach player to platform
        if (other.transform.tag.Contains("Platform"))
        {
            transform.parent = null;
            transform.localScale = new Vector3(1,1,1);
        }
    }
}
