using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenTransition : MonoBehaviour
{
    [SerializeField]
    string scene;
    [SerializeField]
    Animator anim;

    public void PlayAnimation() => anim.enabled = true;

    public void SwitchScene() => SceneManager.LoadScene(scene);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Player"))
            SwitchScene();
    }
}
