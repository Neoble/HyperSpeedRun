using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour
{

    public float objectSpeed = -20f;


    void Update()
    {

        transform.Translate(new Vector3(0, 0, objectSpeed) * Time.deltaTime);

    }
}