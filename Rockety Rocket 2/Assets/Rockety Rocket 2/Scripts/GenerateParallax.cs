using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateParallax : MonoBehaviour
{
    public float radius = 1.0f;
    public GameObject star;
    private GameObject[] stars = new GameObject[150];
    [Range(0f, 1f)]
    public float alpha = 0.5f;

    void Start()
    {
        int count = 0;
        while (count < stars.Length)
        {
            var randomPos = new Vector2(Random.Range(-radius, radius), Random.Range(-radius, radius));

            if (randomPos.magnitude <= radius)
            {

                var newStar = Instantiate(star, randomPos, Quaternion.identity);
                stars[count] = newStar;
                count++;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(Vector3.zero, radius);
    }
}
