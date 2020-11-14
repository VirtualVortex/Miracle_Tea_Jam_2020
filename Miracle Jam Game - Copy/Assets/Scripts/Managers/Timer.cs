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

    public UnityEvent firstEvent;
    public UnityEvent secondtEvent;

    float timer;
    bool onButton;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer && onButton)
        {
            InvokeSecondEvent();
            onButton = false;
        }
    }

    public void InvokeFirstEvent() => firstEvent.Invoke();
    public void InvokeSecondEvent() => secondtEvent.Invoke();

    public void ResetBool() => onButton = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (Time.time > timer && collision.transform.tag.Contains(tag))
        {
            InvokeFirstEvent();
            timer = Time.time + delay;
            onButton = true;
        }
    }
}
