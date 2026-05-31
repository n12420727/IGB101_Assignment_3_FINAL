using UnityEngine;

public class DeleteOnComplete : MonoBehaviour
{  
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.levelComplete) GameObject.Destroy(this.gameObject);
    }
}
