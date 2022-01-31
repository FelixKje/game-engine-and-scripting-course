using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] Rigidbody myRigidbody;
    [SerializeField] PlayerInputController playerInputController;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] float minimumJumpForce = 100f;
    [SerializeField] float maximumJumpForce = 1000f;
    [SerializeField] float chargeTime = 1f;

    float jumpCharge;

    void Update(){
        HandleJump();
    }

    void HandleJump(){
        if (playerInputController.JumpInput)
            jumpCharge += Time.deltaTime / chargeTime;

        if (playerInputController.JumpInputUp){
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;

            if (groundChecker.IsGrounded)
                myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}