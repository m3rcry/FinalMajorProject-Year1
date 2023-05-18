using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject player;
    public GameObject Menu;
    static bool Paused;
    
    void Start()
    {
        Paused = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused = !Paused;
            PauseGame();
        }
    }


    void PauseGame ()
    {
        if(Paused)
        {
            Time.timeScale = 0f;
            player.GetComponent<Shooting>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Menu.SetActive(true);
        }
        else
        {
            Time.timeScale =1;
            player.GetComponent<Shooting>().enabled =true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Menu.SetActive(false);
        }
    }


    public void resume()
    {
        Time.timeScale = 1;
        player.GetComponent<Shooting>().enabled = true;
        Cursor.lockState= CursorLockMode.Confined;
        Cursor.visible = true;
        Menu.SetActive(false);
    }

    public void quit(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}


