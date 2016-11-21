using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MovementScript : MonoBehaviour
{

    public Slider healthBarSlider;
    public Text gameOverText;
    private bool isGameOver = false;

    void Start()
    {
        gameOverText.enabled = false;
    }

    void Update()
    {
        if (!isGameOver)
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10f, 0, 0);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Fire" && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= .011f;
        }
        else
        {
            isGameOver = true;
            gameOverText.enabled = true;
        }
    }
}