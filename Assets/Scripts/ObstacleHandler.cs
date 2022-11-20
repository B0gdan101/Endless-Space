using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Random.Range(5,10);i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, new Vector3(Random.Range(-22.45f, 22.45f), 2.499998f, Random.Range(transform.position.z-100, transform.position.z + 100)),Quaternion.identity);
            obstacle.transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
