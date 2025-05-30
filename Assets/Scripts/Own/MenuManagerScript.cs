using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class MenuManagerScript : MonoBehaviour
{

    public Canvas startMenu;

    public Button playButton;

    public string gotoThisScene;

    void Start()
    {
        startMenu = startMenu.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene( gotoThisScene );
    }

}