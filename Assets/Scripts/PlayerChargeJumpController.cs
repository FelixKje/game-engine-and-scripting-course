using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] MovementApplier movementApplier;
    [SerializeField] CommandContainer commandContainer;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] float minimumJumpForce = 100f;
    [SerializeField] float maximumJumpForce = 1000f;
    [SerializeField] float chargeTime = 1f;

    float jumpCharge;

    void Update() => HandleJump();

        void HandleJump(){
        if (commandContainer.JumpCommand)
            jumpCharge += Time.deltaTime / chargeTime;

        if (commandContainer.JumpCommandUp){
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;

            if (groundChecker.IsGrounded)
                movementApplier.AddForce(Vector3.up * jumpForce);
        }
    }
}