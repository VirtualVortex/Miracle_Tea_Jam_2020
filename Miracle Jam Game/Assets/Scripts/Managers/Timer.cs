using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    string tag;
    [SerializeField]
    float delay;

    public UnityEvent myEvent;

    float timer;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer)
            InvokeEvent();
    }

    public void InvokeEvent() => myEvent.Invoke();

    private void OnCollisionEnter(Collision collision)
    {
        if (Time.time > timer && collision.transform.tag.Contains(tag))
        {
            InvokeEvent();
            timer = Time.time + delay;
        }
    }
}
