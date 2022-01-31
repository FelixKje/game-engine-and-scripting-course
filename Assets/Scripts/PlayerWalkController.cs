using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] MovementApplier movementApplier;
    [SerializeField] CommandContainer commandContainer;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float chargingMoveSpeedFactor = 0.5f;

    void Update() => HandleWalking();

    void HandleWalking(){
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (commandContainer.JumpCommand && groundChecker.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        movementApplier.SetHorizontalVelocity(commandContainer.WalkCommand * currentMoveSpeed);
    }
}
