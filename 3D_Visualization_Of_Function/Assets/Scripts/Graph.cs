using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform pointPrefab;
    void Awake()
    {
        Transform point = Instantiate(pointPrefab);
        point.localPosition = Vector3.right;

        point = Instantiate(pointPrefab);
        point.localPosition = Vector3.right * 2f;
    }
}
