using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu;

    bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isOpen)
        {
            pausemenu.SetActive(true);
            isOpen = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isOpen)
            Resume();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        isOpen = false;
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
