using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("storyline");
    }
    public void Options()
    {
        SceneManager.LoadScene("options");
    }
    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("quitgame");
    }
}
