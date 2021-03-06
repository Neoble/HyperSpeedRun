﻿using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour
{

    void Start () {
	
	}
	void Update ()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
	}

    void OnTriggerEnter(Collider col)
    {
        UIManager.Instance.IncreaseScore(ScorePoints);
        Destroy(this.gameObject);
    }

    public int ScorePoints = 100;
    public float rotateSpeed = 50f;
}
