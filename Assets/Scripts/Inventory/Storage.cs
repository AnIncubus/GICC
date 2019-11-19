using UnityEngine;

public class Storage : MonoBehaviour{

    int woodResource = 0;
    int ïronResource = 0;
    int foodResource = 0;
    int toolResource = 0;
    int goldResource = 0;

    public void UpdateWood(int amt)
    {
        woodResource += amt;
    }

    public void UpdateIron(int amt)
    {
        ïronResource += amt;
    }

    public void UpdateFood(int amt)
    {
        foodResource += amt;
    }

    public void UpdateTools(int amt)
    {
        toolResource += amt;
    }

    public void UpdateGold(int amt)
    {
        goldResource += amt;
    }

    public int GetWood()
    {
        return woodResource;
    }

    public int GetIron()
    {
        return ïronResource;
    }

    public int GetFood()
    {
        return foodResource;
    }

    public int GetTools()
    {
        return toolResource;
    }

    public int GetGold()
    {
        return goldResource;
    }

}
