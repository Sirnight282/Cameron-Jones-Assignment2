using UnityEngine;
using UnityEngine.UI;

public class SelectColor : MonoBehaviour
{
    public Dropdown PickColor;
    public Material ballShader;
    public static Color Color;

    Color red = new Color(255, 0, 0);
    Color green = new Color(0, 255, 0);
    Color blue = new Color(0, 0, 255);
    Color white = new Color(0, 0, 0);

    public void ChangeColor()
    {
        ballShader.color = Color.white;
        switch (PickColor.value)
        {
            case 1:
                Debug.Log("Red Selected");
                ballShader.color = Color.red;

                break;
            case 2:
                Debug.Log("Green Selected");
                ballShader.color = Color.green;
                break;
            case 3:
                Debug.Log("Blue Selected");
                ballShader.color = Color.blue;
                break;
            default:
                Debug.Log("Please Select A Color");
                ballShader.color = Color.white;
                break;
        }
    }

}