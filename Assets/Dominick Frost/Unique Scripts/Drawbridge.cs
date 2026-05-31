using UnityEngine;

public class Drawbridge : MonoBehaviour
{
    public Animator anim;

    private float timeToDraw = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToDraw += Time.deltaTime;
        if (timeToDraw > 8 && anim.GetBool("Opening") == true)
        {
            anim.SetBool("Opening", false);
            timeToDraw = 0;
        }
        else if (timeToDraw > 8 && anim.GetBool("Opening") == false) 
        { 
            anim.SetBool("Opening", true);
            timeToDraw = 0;
        }
    }
}
