using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_manager : MonoBehaviour
{
    public float bgSpeed;
    public GameObject _obstacle;
    Vector3 startPos;
    GameObject front_;
    // Start is called before the first frame update
    void Start()
    {
        front_ = (GameObject)Instantiate(_obstacle);
        startPos = new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        front_.transform.Translate((new Vector3(-1, 0, 0)) * bgSpeed * Time.deltaTime);
        if (front_.transform.position.x < -10.2)
        {
            Destroy(front_);
            front_ = (GameObject)Instantiate(_obstacle, startPos, Quaternion.identity);
        }
    }
}
