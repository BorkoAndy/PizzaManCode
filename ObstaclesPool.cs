using System.Collections.Generic;
using UnityEngine;

public class ObstaclesPool : MonoBehaviour
{
    [SerializeField] private Obstacle[] obstaclePrefabs;
    [SerializeField] private int queueCapacity;
    
    public static Queue<Obstacle> pool;

    private void Awake() => CreatePool();
    private void CreatePool()
    {
        pool = new Queue<Obstacle>();
        for (int i = 0; i < queueCapacity; i++) 
        {
            Obstacle newObstacle = Instantiate(obstaclePrefabs[Random.Range(0,obstaclePrefabs.Length)]); 
            newObstacle.gameObject.SetActive(false);
            pool.Enqueue(newObstacle);            
        }
    }    
}
