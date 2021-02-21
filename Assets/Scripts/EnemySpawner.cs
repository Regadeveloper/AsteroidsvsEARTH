using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject [] obstacles ;
    // Start is called before the first frame update
    void Start()
    {
        IniciarSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IniciarSpawn()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(0, 4.33f), Quaternion.identity);
        yield return new WaitForSeconds(3);
        IniciarSpawn();

    }
}
