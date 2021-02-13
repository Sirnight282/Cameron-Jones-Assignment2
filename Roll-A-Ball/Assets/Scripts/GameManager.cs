using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     
    public static bool BigBallBool;
    public Toggle BigMode;


    public void toggleBigMode()
    {
        BigBallBool = !BigBallBool;
        Debug.Log("Big Mode = " + BigBallBool);
    }

    private void Start()
    {
        if (BigBallBool)
        {
            BigMode.isOn = true;
            BigBallBool = true;
        }
    }
}
