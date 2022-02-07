using UnityEngine;
using UnityEngine.Events;

public class ChargeJumpController : MonoBehaviour
{
    [SerializeField] Rigidbody myRigidbody;
    [SerializeField] CommandContainer commandContainer;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] float minimumJumpForce = 100f;
    [SerializeField] float maximumJumpForce = 1000f;
    [SerializeField] float chargeTime = 1f;
    [SerializeField] UnityEvent<float> onChargeJump;

    float jumpCharge;

    void Update() => HandleJump();

        void HandleJump(){
            if (commandContainer.JumpCommand){
                jumpCharge += Time.deltaTime / chargeTime;
                jumpCharge = Mathf.Clamp01(jumpCharge); 
            }
            

        if (commandContainer.JumpCommandUp){
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            

            if (groundChecker.IsGrounded){
                myRigidbody.AddForce(Vector3.up * jumpForce);
                onChargeJump.Invoke(jumpCharge);
            }
            jumpCharge = 0f;
        }
    }
}