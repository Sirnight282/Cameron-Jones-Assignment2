using UnityEngine;
using UnityEngine.UI;

public class SetToDefault : MonoBehaviour
{
    public Material ballShader;
    public static Color Color;

    Color white = new Color(0, 0, 0);

    void Start()
    {
        ballShader.color = Color.white;
    }

}