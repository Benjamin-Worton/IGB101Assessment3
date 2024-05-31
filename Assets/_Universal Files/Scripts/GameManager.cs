using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
    public Text pickupText;
    public Text goalText;
    public ParticleSystem exitPortal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
            if(exitPortal.isStopped)
            {
                exitPortal.Play();
            }

        }
        else
        {
            levelComplete = false;
        }

    }

    private void UpdateGUI()
    {
        pickupText.text = currentPickups + "/" + maxPickups;

        if (levelComplete && SceneManager.GetActiveScene().name == "Benjamin Worton Scene")
        {
            goalText.text = "Enter the Portal";
        }
        else
        {
            goalText.text = "Collect the Gems";
        }
    }

}
