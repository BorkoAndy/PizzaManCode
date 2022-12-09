using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{    
    [SerializeField] private GameObject player;
    [SerializeField] private float distanseToSpawnObstacle;
    [SerializeField] private Transform destinationPoint;

    private bool canSpawn = false;
    private Obstacle newObstacle; 

    private void Update()
    {
        if (!canSpawn) SpawningCondition();
        else SpawnObstacle();       
    }
    private void SpawningCondition()
    {
        if ((transform.position - player.transform.position).magnitude < distanseToSpawnObstacle) 
            canSpawn = true;
    }
    private void SpawnObstacle()
    {
        newObstacle = ObstaclesPool.pool.Dequeue();
        newObstacle.destinationPoint = destinationPoint;
        newObstacle.transform.position = transform.position;
        newObstacle.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
