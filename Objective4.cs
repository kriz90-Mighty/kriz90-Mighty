using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective4 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Vehicle")
        {
            ObjectiveComplete.occurrence.GetObjectivesDone(true, true, true, true);

            SceneManager.LoadScene("MainMenu");
        }
    }
}
