using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
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

        _rigidbody.velocity = new Vector3(commandContainer.WalkCommand * currentMoveSpeed, _rigidbody.velocity.y,0);
    }
}
