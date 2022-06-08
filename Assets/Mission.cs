using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    [SerializeField] private GameObject missionDisplay;

    private Objective refObject;

    public void SetMission(Objective col)
    {
        missionDisplay.SetActive(true);
        refObject = col;
    }

    public void FinishMission()
    {
        missionDisplay.SetActive(false);
        refObject.UnlockMovement();
    }
    
    
    
    
}
