using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown_Action : MonoBehaviour
{
    List<string> names = new List<string>() { "Please Select Action", "Extinguish Fire", "Open/Close Door", "Chop down Wall", "Call Ambulance", "Drive Engine", "Fire Deck Gun", "Pickup", "Swap Role", "Resuscitate Victim", "Remove HazMat", "Identify", "Move other fireman" };

    public Dropdown dropdown;
    public Text selectedAction;
    
    public void Dropdown_IndexChanged(int index)
    {
        //selectedAction.text = names[index];
        if (index == 0)
        {
            selectedAction.text = "?";
            selectedAction.color = Color.red;
        }
        else
        {
            selectedAction.text = "Go";
            selectedAction.color = Color.green;
        }
    }
    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        
        dropdown.AddOptions(names);
    }
}
