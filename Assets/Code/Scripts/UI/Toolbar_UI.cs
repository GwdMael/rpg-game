using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Toolbar_UI : MonoBehaviour
{
    // Initialize the toolbar slots
    [SerializeField] private List<Slot_UI> toolbarSlots = new List<Slot_UI>();

    // Initialize the selected slot
    private Slot_UI selectedSlot;

    private void Start()
    {
        SelectSlot(0);      
    }

    private void Update()
    {
        ChackAlphaNumericKeys();
    }

    public void SelectSlot(int index)
    {
        if (toolbarSlots.Count == 10)
        {
            if (selectedSlot != null)
            {
                selectedSlot.SetHighlight(false);
            }
            selectedSlot = toolbarSlots[index];
            selectedSlot.SetHighlight(true);
        }
    }

    private void ChackAlphaNumericKeys()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectSlot(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectSlot(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectSlot(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SelectSlot(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SelectSlot(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SelectSlot(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SelectSlot(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SelectSlot(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SelectSlot(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SelectSlot(9);
        }

    }
}
