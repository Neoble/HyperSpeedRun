using UnityEngine;
using System.Collections;

public class SwipeCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == GameManager.Constants.PlayerTag)
            GameManager.Instance.CanSwipe = true;
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == GameManager.Constants.PlayerTag)
            GameManager.Instance.CanSwipe = false;
    }
}
