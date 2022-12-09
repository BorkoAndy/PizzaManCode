using UnityEngine;

public class Obstacle : MonoBehaviour
{    
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    public Transform destinationPoint;
    private float speed;
    private void Start()
    {        
        transform.LookAt(destinationPoint.position);
        speed = Random.Range(minSpeed, maxSpeed);
    }
    private void Update()
    {
        Move();

        if(transform.position == destinationPoint.position)
            ReturnToPool();    
    }
    private void Move() => transform.position = Vector3.MoveTowards(transform.position, destinationPoint.position, speed * Time.deltaTime);
    private void ReturnToPool()
    {
        this.gameObject.SetActive(false);
        ObstaclesPool.pool.Enqueue(this);
    }
}
