using UnityEngine;
using UnityEngine.Events;

public class ImmediateJumpController : MonoBehaviour{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] CommandContainer commandContainer;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] float jumpForce = 500f;
    [SerializeField] UnityEvent onJump;

    void Update() => HandleJump();

        void HandleJump(){
        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (commandContainer.JumpCommandDown && groundChecker.IsGrounded){
            _rigidbody.AddForce(Vector3.up * jumpForce);
            onJump.Invoke();
        }
            
    }
}
