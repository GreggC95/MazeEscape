using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue = 1;
    
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ony do 
        if (collision.GetComponent<Player>())
        {
            //updating the score based on how nuch this item is worth
            scoreTracker.ChangeValue(scoreValue);


            //get rid of the item (it's been used up) 
            Destroy(gameObject);
        }
    }



}
