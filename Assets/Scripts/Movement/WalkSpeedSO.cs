using UnityEngine;

[CreateAssetMenu(fileName = "New Custom Walk Speed", menuName = "Our Scriptable Objects/Movement/Move Speed")]
public class WalkSpeedSO : ScriptableObject{
    [SerializeField] float walkSpeed = 5f;
    public float WalkSpeed => walkSpeed;
}
