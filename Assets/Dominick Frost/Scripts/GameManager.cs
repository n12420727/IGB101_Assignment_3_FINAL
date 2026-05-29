using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 9;
    public bool levelComplete = false;
    public Text pickupText;

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        }
        else
        {
            levelComplete = false;
        }
    }

    private void UpdateGUI()
    {
        pickupText.text = $"Pickups: {currentPickups}/{maxPickups}";
        if (levelComplete)
        {
            pickupText.color = Color.green;
        }
        else
        {
            pickupText.color = Color.red;
        }
    }

    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }
}
