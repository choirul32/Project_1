using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_control : MonoBehaviour
{
    public float jumpHeight;
    private bool isJump = false;
    private Rigidbody2D _rigidBody2D;
    private Animator anim_character;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        anim_character = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump) // both conditions can be in the same branch
        {
            _rigidBody2D.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse); // you need a reference to the RigidBody2D component
            anim_character.SetBool("jump_anim", true);
            isJump = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground") // GameObject is a type, gameObject is the property
        {
            anim_character.SetBool("jump_anim", false);
            isJump = false;
        }
        if (col.gameObject.tag == "obstacle") // GameObject is a type, gameObject is the property
        {
            Debug.Log("Die");
        }
    }
}
