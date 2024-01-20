using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Fade fade;
    
    IEnumerator SceneTransition(int scene) 
    { 
        yield return new WaitForSeconds(fade.BeginFade(1));
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame(int difficulty)
    {
        GameManager.difficulty = difficulty;
        StartCoroutine(SceneTransition(0));
    }
    void Start()
    {
        fade.BeginFade(-1);
    }
}
