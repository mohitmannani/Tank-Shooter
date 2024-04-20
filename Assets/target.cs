using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public int points = 1;
    public float minDistancez = -10f;
    public float maxDistancez = 4f;
    public float minDistancex = -9f;
    public float maxDistancex = 6f;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Score.Instance.AddPoints(points);
            transform.position = GetRandomPosition();
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 position = new Vector3(Random.Range(minDistancex, maxDistancex), 1.5f, Random.Range(minDistancez, maxDistancez));
    
        return position;
    }
}
