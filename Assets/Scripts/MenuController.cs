using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //On start, go to the gameplayscene.
    public void OnStartClick()
    {

        SceneManager.LoadScene("GameplayScene");

    }

    //when exit button is clicked, exit out of game.
    public void OnExitClick()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();

    }

    public void OnCreditsClick()
    {

        Debug.Log("Going to credits");

        SceneManager.LoadScene("CreditsScene");

    }

    public void OnMainMenuClick()
    {

        SceneManager.LoadScene("StartScene");

    }

}
