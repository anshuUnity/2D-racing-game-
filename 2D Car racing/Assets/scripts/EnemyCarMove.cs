using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMove : MonoBehaviour
{

    public float speedEnemyCar = 5f; // speedwith which enemy car move

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speedEnemyCar * Time.deltaTime);
    }
}
