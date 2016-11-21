using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {
    public bool HasCollision { get; set; }
    public GameObject IgnoreGameobject;

    void OnCollisionStay(Collision collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject != IgnoreGameobject)
        {
            HasCollision = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        HasCollision = false;
    }

    void Start()
    {
        HasCollision = false;
    }

    void Update()
    {
        Debug.Log("Gameobject = " + this.name + " HasCollision = " + HasCollision);
    }
}

