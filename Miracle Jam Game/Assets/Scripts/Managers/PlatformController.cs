using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformController : MonoBehaviour
{
    public UnityEvent firstEvent;
    public UnityEvent secondtEvent;

    float timer, i;
    bool onButton;

    private void Start() => i = 1;

    // Update is called once per frame
    void Update()
    {
        if (i == 1)
            InvokeFirstEvent();
        else if (i == 2)
            InvokeSecondEvent();
    }

    public void SwitchEvents() => i = i == 1 ? 2 : 1;

    public void InvokeFirstEvent() => firstEvent.Invoke();
    public void InvokeSecondEvent() => secondtEvent.Invoke();
}
