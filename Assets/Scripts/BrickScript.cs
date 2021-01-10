using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

    public int points;
    public int hits;
    public Sprite broken;
    public Manager m;
    public GameObject particle;
    public SpriteRenderer renderer;
    public AudioSource audio;
    public AudioSource brick;
    public void Break()
    {
   
        
        hits--;
        if (hits == 0)
        {
            
            Destroy(gameObject);
            Instantiate(particle, transform.position, particle.transform.rotation);

            m.UpdateScore(gameObject.GetComponent<BrickScript>().points);
            m.UpdateNumberOfBricks();
            audio.Play();
        }

        if (hits == 1)
        {
            GetComponent<SpriteRenderer>().sprite = broken;
            brick.Play();

     
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
