using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    // Use this for initialization

    public GameControlScript control;
    CharacterController controller;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    public CountdownScript count;
    public PauseMenuScript pause;
                                 
    public AudioSource powerupCollectSound;
    public AudioSource jumpSound;
    public AudioSource snagCollectSound;


    void Start()
    {

        controller = GetComponent<CharacterController>();
    }


    void Update()
    {

        if (controller.isGrounded && count.isCountDown)
        {

            GetComponent<Animation>().Play("run");

            if (pause.paused == false)
                gameObject.GetComponent<AudioSource>().enabled = true;
            else
                gameObject.GetComponent<AudioSource>().enabled = false;
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            jumpSound.Stop();
            if (Input.GetButton("Jump"))
            {
                GetComponent<Animation>().Stop("run");
                GetComponent<Animation>().Play("jump_pose");

                jumpSound.Play();
                gameObject.GetComponent<AudioSource>().enabled = false;
                moveDirection.y = jumpSpeed;
            }

        }
 
        if (control.isGameOver)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Powerup(Clone)")
        {
            powerupCollectSound.Play(); 
            control.PowerupCollected();
        }
        else if (other.gameObject.name == "Obstacle(Clone)")
        {
            snagCollectSound.Play(); 
            control.AlcoholCollected();
        }
        Destroy(other.gameObject);
    }
}