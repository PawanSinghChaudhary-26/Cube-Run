using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbdy;             //reference variable for Rigidbody component
    public float force = 980f;
    public float speed= 10f;
    public float maxX;                    //preventing the cube from falling of the track from both sides
    public float minX;

    void Start()             // Start is called before the first frame update
    {
        
    }


    void Update()           // Update is called once per frame
    {
        Vector3 playerpos = transform.position;       // created a variable playerpos of vector 3 coz x,y,z directions;
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);      // fixing the edge slide down issue of player.....
        transform.position = playerpos;
        //rigidbdy.AddForce(0, 0, force * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }


    }  


    private void FixedUpdate()
    {
        rigidbdy.AddForce(0, 0, force*Time.deltaTime);         //helps the cube to move forward 
    }
}


// transform.position = transform.position + new Vector3(0, 0, 10f * Time.deltaTime);
//rigidbdy.AddForce(0, 0, 1000f* Time.deltaTime);

/*if (playerpos.x < minX)
{
    playerpos.x = minX;
}
if (playerpos.x > maxX)
{
    playerpos.x = maxX;
}*/
