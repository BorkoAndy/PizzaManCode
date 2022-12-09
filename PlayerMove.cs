using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update() => Move();

    private void Move() => transform.Translate(Vector3.forward * (speed + RoundHandle.Speeder) * Time.deltaTime);

}
