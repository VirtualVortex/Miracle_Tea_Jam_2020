using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField]
    float speed;

    PlatformController pc;
    int[] numbers = new int[4] {0,90,180,270};
    int i;

    private void Awake() => pc = GameObject.FindObjectOfType<PlatformController>();

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Call method with different keys
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            i++;
            pc.SwitchEvents();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            i--;
            pc.SwitchEvents();
        }

        if (i > numbers.Length - 1)
            i = 0;
        else if (i < 0)
            i = numbers.Length - 1;

        Rotate();
    }

    //Rotate camera
    public void Rotate() => transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, numbers[i], 0), speed);
}
