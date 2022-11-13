using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    private const int SPEED = 2;

    // Update is called once per frame
    void Update()
    {
        //*Time.deltaTime adjusts for different speed on computers
        transform.Rotate(SPEED * Time.deltaTime * new Vector3(0, 20, 0));
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * .4f, 0.2f) + 0.5f, transform.position.z);
    }
}
