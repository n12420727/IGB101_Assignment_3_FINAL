using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    public Text pickupText;

    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false; 

private void UpdateGUI(){
    pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
}

private void LevelCompleteCheck(){
    if (currentPickups >= maxPickups)
        levelComplete = true;
    else
        levelComplete = false;

}
void Update(){
    LevelCompleteCheck();
    UpdateGUI();
}
}
