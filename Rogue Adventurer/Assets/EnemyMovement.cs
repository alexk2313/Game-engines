using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Transform target;
    private float move;

    Rigidbody2D rgbd2;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rgbd2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }
}
