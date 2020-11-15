using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformController : MonoBehaviour
{
    public UnityEvent firstEvent;
    public UnityEvent secondtEvent;

    float timer, i, state;
    bool onButton;

    private void Start() => i = 1;

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchEvents()
    {
        if (i == 1)
        {
            InvokeFirstEvent();
            i = 2;
        }

        if (i == 2)
        {
            InvokeSecondEvent();
            i = 1;
        }
    }

    public void InvokeFirstEvent() => firstEvent.Invoke();
    public void InvokeSecondEvent() => secondtEvent.Invoke();
}
