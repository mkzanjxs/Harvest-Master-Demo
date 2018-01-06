using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriterenderer;
    public float speed = 0.001f;

    private float degree;
    private bool is_move;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        spriterenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //is_move = false;
        /*if(Input.GetKey(KeyCode.UpArrow))
		{
            animator.SetInteger("direction", 1);
            is_move = true;
            transform.position = transform.position + new Vector3(0, Time.deltaTime * speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("direction", 2);
            is_move = true;
            transform.position = transform.position + new Vector3(0, -Time.deltaTime * speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("direction", 3);
            is_move = true;
            transform.position = transform.position + new Vector3(-Time.deltaTime * speed, 0, 0);
            spriterenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("direction", 4);
            is_move = true;
            transform.position = transform.position + new Vector3( Time.deltaTime * speed,0, 0);
            spriterenderer.flipX = true;
        }
        if (!animator.GetBool("is_move") == is_move)
        {
            animator.SetBool("is_move", is_move);
        }*/
        //animator.SetFloat("dir_floar", degree);

        degree = animator.GetFloat("degree");
        is_move = animator.GetBool("is_move");
        //Debug.Log(degree);
        if (is_move)
        {
            transform.position = transform.position + new Vector3(Time.fixedDeltaTime * speed * Mathf.Cos(-Mathf.Deg2Rad * degree), Time.fixedDeltaTime * speed * Mathf.Sin(-Mathf.Deg2Rad * degree), 0);
            
            //Debug.Log(Mathf.Cos(Mathf.Deg2Rad * degree) + ";" + Mathf.Sin(Mathf.Deg2Rad * degree));
        }
        if (Mathf.Abs(degree) <= 45)
        {
            spriterenderer.flipX = true;
        }else
        {
            spriterenderer.flipX = false;
        }

    }
}
