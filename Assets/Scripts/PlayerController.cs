using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotateSpeed = 10f;
    [SerializeField] private LayerMask _FloorMask; 
    
    private Vector3? _MovePoint = null;
    private Vector3 _Direction;
    private Quaternion _TargetRotation;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            StopMove();
            ComputeRotation();
        }
        else if (Input.GetMouseButton(0))
        {
            ComputeTarget();
        }
    }

    private void ComputeTarget()
    {
        Ray screenRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(screenRay, out RaycastHit hit, 100, _FloorMask))
        {
            Debug.Log(hit.point);
        }
    }

    private void StopMove()
    {
        Debug.Log("Stop Move");
    }

    private void ComputeRotation()
    {
        Debug.Log("Compute Rotation");
    }
}

  