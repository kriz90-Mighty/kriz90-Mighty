using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveComplete : MonoBehaviour
{
   [Header("Objectives to complete")]
   public Text objective1;
   public Text objective2;
   public Text objective3;
   public Text objective4;

   public static ObjectiveComplete occurrence;

   private void Awake()
   {
    occurrence = this;
   }

   public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4)
   {
    if(obj1 == true)
    {
        objective1.text = "1. Completed";
        objective1.color = Color.green;
    }
    else
    {
        objective1.text = "01. Find the rifle";
        objective1.color = Color.white;
    }


    if(obj2 == true)
    {
        objective2.text = "1. Completed";
        objective2.color = Color.green;
    }
    else
    {
        objective2.text = "02. Locate the villagers";
        objective2.color = Color.white;
    }


    if(obj3 == true)
    {
        objective3.text = "1. Completed";
        objective3.color = Color.green;
    }
    else
    {
        objective3.text = "03. Find the vehicle";
        objective3.color = Color.white;
    }


    if(obj4 == true)
    {
        objective4.text = "1.Mission Completed";
        objective4.color = Color.green;
    }
    else
    {
        objective4.text = "04. Get the villagers into the vehicle";
        objective4.color = Color.white;
    }

   }
}
