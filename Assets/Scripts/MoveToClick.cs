using UnityEngine;
using System.Collections;

public class MoveToClick : MonoBehaviour
{

    GameObject player;
    RaycastHit hit;
    Vector3 playerPos = new Vector3(0, 5, 0);
    float speed;

    Vector3 previousPosition;
    Vector3 targetPosition;
    float lerpMoving;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        player.transform.position = playerPos;
        speed = 100.0f;
        hit = new RaycastHit();
        //speed = speed * Time.deltaTime;

    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 1000.0f))
                {
                    previousPosition = transform.position;
                    targetPosition = hit.point;
                    lerpMoving = 0;
                }
            }
        }
        if (lerpMoving < 1)
            movePlayer();
    }

    void movePlayer()
    {
        lerpMoving += Time.deltaTime;
        transform.position = Vector3.MoveTowards(previousPosition, targetPosition, speed * lerpMoving);
    }
}
         