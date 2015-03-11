using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    float hAxis;
    float vAxis;


    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        Vector3 mov = new Vector3(hAxis, 0f, vAxis);
        GetComponent<Rigidbody>().AddForce(mov * speed * Time.deltaTime);
    }
}
