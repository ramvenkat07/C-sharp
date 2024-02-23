using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesInstantiation : MonoBehaviour
{
    [SerializeField]
    GameObject ObstaclesPrefab;
    void Start()
    {
        StartCoroutine(ObstacelCreation());
    }

    IEnumerator ObstacelCreation()
    {
        while(true)
        {
            GameObject obstacle = Instantiate(ObstaclesPrefab, transform);
            obstacle.transform.position = new Vector3(obstacle.transform.position.x, Random.Range(-4, 6), 0);
            yield return new WaitForSeconds(1f);
        }
    }

}
