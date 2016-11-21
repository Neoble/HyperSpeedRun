using UnityEngine;
using System.Collections;

public class CharacterSidewaysMovement : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20f;
    private CharacterController controller;
    private Animator anim;

    private bool isChangingLane = false;
    private Vector3 locationAfterChangingLane;
    private Vector3 sidewaysMovementDistance = Vector3.right * 2f;

    public float SideWaysSpeed = 5.0f;

    public float JumpSpeed = 8.0f;
    public float Speed = 6.0f;
    public Transform CharacterGO;

    IInputDetector inputDetector = null;

    void Start()
    {
        moveDirection = transform.forward;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= Speed;

        UIManager.Instance.ResetScore();
        UIManager.Instance.SetStatus(GameManager.Constants.StatusTapToStart);

        GameManager.Instance.GameState = GameState.start;

        anim = CharacterGO.GetComponent<>();
        inputDetector = GetComponent<>();
        controller = GetComponent<>();
    }

}
