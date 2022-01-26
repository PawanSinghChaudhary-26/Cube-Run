using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerScript playerscript;
    public Move move;
    public Score score;
    public GameController gameController;
    public PlayerCollision playerCollision;
    public AudioSource audiosource;
    public AudioSource audiosource1;
    public AudioSource audiosource2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "COLLECTABLES")
        {
            audiosource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.name); 
        //Debug.Log("player collided");
        if (other.gameObject.tag == "OBSTACLES")
        {
            audiosource1.Play();
            gameController.GameOver();
            move.StopAllCoroutines(); 
            playerscript.enabled = false;
             move.enabled = false;
           
        }
        else if(other.gameObject.tag == "WIN")
        {
            audiosource2.Play();
            gameController.GameWin();
            move.StopAllCoroutines();
            playerscript.enabled = false;
            move.enabled = false;
        }
    }
}
