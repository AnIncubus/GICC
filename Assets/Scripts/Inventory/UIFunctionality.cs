using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFunctionality : MonoBehaviour
{

    [SerializeField] Storage storage;

    public void AddWood()
    {
        storage.UpdateWood(2);
    }

    public void AddIron()
    {
        storage.UpdateIron(2);
    }

    public void AddGold()
    {
        storage.UpdateGold(2);
    }

    public void AddTools()
    {
        if(storage.GetIron() >= 2 && storage.GetWood() >= 1)
        {
            storage.UpdateTools(2);
            storage.UpdateIron(-2);
            storage.UpdateWood(-1);
        }
    }

    public void AddFood()
    {
        storage.UpdateFood(2);
    }

}
