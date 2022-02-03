using UnityEngine;

public class WalkController : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] CommandContainer commandContainer;
    [SerializeField] GroundChecker groundChecker;
    [SerializeField] WalkSpeedSO walkSpeedSo;
    [SerializeField] float chargingMoveSpeedFactor = 0.5f;

    void Update() => HandleWalking();

    void HandleWalking(){
        //Slower move speed while charging a jump.
        var currentMoveSpeed = walkSpeedSo.WalkSpeed;
        if (commandContainer.JumpCommand && groundChecker.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        //Vector3.MoveTowards(); //possible solution to apply Addforce correctly from jumppad
        _rigidbody.velocity = new Vector3(commandContainer.WalkCommand * currentMoveSpeed, _rigidbody.velocity.y,0);
    }
}
