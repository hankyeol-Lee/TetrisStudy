using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tf;
    Animator animator;
public float movespeed = 0.01f;
    // Start is called before the first frame update
    void Start() //변수 초기화
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.Play("CHARA_MOVE");
            tf.rotation = Quaternion.Euler(0f,180f,0f);
            tf.position = new Vector3(transform.position.x - movespeed, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.Play("CHARA_MOVE");
            tf.rotation = Quaternion.Euler(0f,0f,0f);
            tf.position = new Vector3(transform.position.x + movespeed, transform.position.y, transform.position.z);
        }
        else
        {
            animator.Play("CHARA_IDLE");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * 0.1f, ForceMode2D.Impulse);
        }
    }
    


}