using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float bgSpeed;
    public GameObject bg_front;
    public GameObject bg_front_2;
    Vector3 startPos;
    GameObject front_;
    GameObject front_2;
    // Start is called before the first frame update
    void Start()
    {
        front_ = (GameObject)Instantiate(bg_front);
        front_2 = (GameObject)Instantiate(bg_front_2);
        startPos = front_2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        front_.transform.Translate((new Vector3(-1, 0,0)) * bgSpeed * Time.deltaTime);
        front_2.transform.Translate((new Vector3(-1, 0,0)) * bgSpeed * Time.deltaTime);
        if(front_.transform.position.x < -19.2){
            Destroy(front_);
            front_ = (GameObject)Instantiate(bg_front, startPos, Quaternion.identity);
        }
            
        if(front_2.transform.position.x < -19.2){
            Destroy(front_2);
            front_2 = (GameObject)Instantiate(bg_front, startPos, Quaternion.identity);
        }
    }
}
