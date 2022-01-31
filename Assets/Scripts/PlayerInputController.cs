using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float MoveInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInputUp { get; private set; }
    public bool JumpInput { get; private set; }

    void Update(){
        GetInput();
    }

    void GetInput(){
        MoveInput = Input.GetAxis("Horizontal");
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
        JumpInput = Input.GetKey(KeyCode.Space);
    }
}