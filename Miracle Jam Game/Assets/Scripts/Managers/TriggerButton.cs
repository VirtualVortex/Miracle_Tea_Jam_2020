using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerButton : MonoBehaviour
{
    [SerializeField]
    string tag;
    public UnityEvent myEvent;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvokeEvent() => myEvent.Invoke();

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag.Contains(tag))
            InvokeEvent();

    }
}
