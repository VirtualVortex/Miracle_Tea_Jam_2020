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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isOpen)
        {
            pausemenu.SetActive(true);
            isOpen = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isOpen)
        {
            pausemenu.SetActive(false);
            isOpen = false;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        isOpen = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
