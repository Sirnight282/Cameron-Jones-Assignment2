using UnityEngine;
using UnityEngine.UI;

public class BigBallToggle : MonoBehaviour
{
    public static bool BigBall = false;
    
    public void BigMode()
    {
        if (BigBall == true)
        {
            BigBall = true;
            Debug.Log("Big Mode On");
        }
        else
        {
            BigBall = false;
            Debug.Log("Big Mode Off");
        }
    }

    
}
