using UnityEngine;
using System.Collections;

public class TimeDestroyer : MonoBehaviour

{
    void Start()
    {

        Invoke("DestroyObject", LifeTime);
    }

    void DestroyObject()
    {
        if (GameManager.gameState != GameState.dead)
            Destroy(gameObject);
    }

    public float LifeTime = 10f;
}