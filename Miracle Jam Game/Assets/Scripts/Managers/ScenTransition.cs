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
    [SerializeField]
    string animation;

    public void PlayAnimation() => anim.Play(animation);

    public void SwitchScene() => SceneManager.LoadScene(scene);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Player"))
            SwitchScene();
    }
}
