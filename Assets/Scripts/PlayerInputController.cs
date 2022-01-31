using UnityEngine;

public class PlayerInputController : MonoBehaviour{
    [SerializeField] CommandContainer commandContainer;
    float walkInput;
    bool jumpInputDown;
    bool jumpInputUp;
    bool jumpInput;

    void Update(){
        SetCommands();
        GetInput(); 
    } 

    void GetInput(){
        walkInput = Input.GetAxis("Horizontal");
        jumpInputDown = Input.GetKeyDown(KeyCode.Space);
        jumpInputUp = Input.GetKeyUp(KeyCode.Space);
        jumpInput = Input.GetKey(KeyCode.Space);
    }

    void SetCommands(){
        commandContainer.WalkCommand = walkInput;
        commandContainer.JumpCommandDown = jumpInputDown;
        commandContainer.JumpCommandUp = jumpInputUp;
        commandContainer.JumpCommand = jumpInput;
    }
}