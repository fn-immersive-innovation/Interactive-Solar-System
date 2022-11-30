using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemOrbit : MonoBehaviour
{
    public Vector3 rotateValue;

    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the earth!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateValue * Time.deltaTime * speed);
    }
}
