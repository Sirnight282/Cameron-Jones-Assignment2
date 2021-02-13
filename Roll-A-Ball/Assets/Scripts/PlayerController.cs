using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public static float Multiplier = SliderValueToText.sliderValueFloat;
    public float speed = 800.0f ;
    public Text scoreText;
    private int count = 0;
    public Text WinText;
    
    private void Start()
    {
        Debug.Log("Multiplier: " + Multiplier);
        Debug.Log("Speed: " + speed);
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * (speed * Multiplier) * Time.deltaTime);
        if (count >= 20)
        {
            WinText.gameObject.SetActive(true);
            SceneManager.LoadScene("Credits");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
        }
    }
}
