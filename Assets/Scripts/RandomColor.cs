using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public SpriteRenderer Brick;
    
    // Start is called before the first frame update
    void Start()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        Brick.color = new Color(r, g, b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
