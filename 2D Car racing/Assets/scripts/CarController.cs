using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    Vector3 position;
    public float maxPos = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -2.0f, 2.0f);
        transform.position = position;
    }
}
