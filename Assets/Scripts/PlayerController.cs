using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    public GUIText countText;
    public GUIText winText;
    
    private int count = 0;

    float hAxis;
    float vAxis;

    void Start()
    {
        setCount(0);
        winText.text = "";
    }

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

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickup")
        {
            int c = GameObject.FindGameObjectsWithTag("pickup").Length;
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            setCount(++count);
            
            if(c == 1)
            {
                winText.text = "Yay, you win!";
            }
           
        }
    }


    private void setCount(int c)
    {
        count = c;
        countText.text = "Count: " + count;
    }

}
