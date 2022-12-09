using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject cameraTarget;

    private Vector3 offset;
    private void Start() => offset = cameraTarget.transform.position - transform.position;

    private void LateUpdate() => transform.position = cameraTarget.transform.position - offset;
}
