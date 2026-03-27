using UnityEngine;

public class CharacterController : MonoBehaviour
{
   [SerializeField] private float _moveSpeed = 5f;
   [SerializeField] private float _rotateSpeed = 10f;
   
   private Vector3? _movePoint = null;
   private Vector3 _moveDirection;
   private Quaternion _targetRotation;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            stopMove();
            computeRotatiob();
        }
        else if (Input.GetMouseButton(0))
        {
            ComputeTarget();
        }
              
    }

    private void ComputeTarget()
    {
        Debug.Log("compute Target");
    }

    private void stopMove()
    {
        Debug.Log("Stop Move");
    }

    private void computeRotatiob()
    {
        Debug.Log("Compute Rotation");
    }
}
