using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        Debug.Log("BigBallBool on start: " + GameManager.BigBallBool);
        //Debug.Log("isBig on start: " + isBig);
        if (GameManager.BigBallBool)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
