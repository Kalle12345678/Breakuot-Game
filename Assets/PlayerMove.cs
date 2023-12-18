using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rigi;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigi.AddForce(new Vector3(-130, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigi.AddForce(new Vector3(130, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigi.AddForce(new Vector3(-130, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigi.AddForce(new Vector3(130, 0, 0));
        }
    }
}
