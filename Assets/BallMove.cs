using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody rigi;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();

        rigi.AddForce(new Vector3(-5, -300, 0));
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 8;
        rigi.velocity = rigi.velocity.normalized * speed;

        if (transform.position.y < -2)
        {
            rigi.velocity = new Vector3(-5, -300, 0);
            transform.position = new Vector3(-0.9f, 3.75f, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        Enemy hitenemy = otherGameObject.GetComponent<Enemy>();

        if (hitenemy != null)
        {
            hitenemy.TakeDamage();
        }
    }
}