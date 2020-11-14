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
        Debug.Log(i);

        if (state == 1)
        {
            InvokeFirstEvent();
            i = 1;
        }
        else if (state == 2)
        {
            InvokeSecondEvent();
            i = 2;
        }
    }

    public void SwitchEvents() => state = i == 2 ? 1 : 2;

    public void InvokeFirstEvent() => firstEvent.Invoke();
    public void InvokeSecondEvent() => secondtEvent.Invoke();
}
