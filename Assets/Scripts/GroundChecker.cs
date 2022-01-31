using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    [SerializeField] float groundCheckLength = 1f;
    [SerializeField] float groundCheckRadius = 0.5f;
    [SerializeField] LayerMask groundLayers;

    void Update(){
        CheckGround();
    }

    void CheckGround(){
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius, groundCheckLength, groundLayers);

        // Debug.DrawRay(transform.position, Vector3.down * groundCheckLength, Color.magenta);
    }

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawSphere(transform.position + Vector3.down * groundCheckLength, groundCheckRadius);
    // }
}
