using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float tunSpeed = 100f;
    public InputAction MoveAction;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();
        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //transform.Translate(Vector3.right * Time.deltaTime * tunSpeed * moveInput.x);
        transform.Rotate(Vector3.up, Time.deltaTime * tunSpeed * moveInput.x);
    }
}
