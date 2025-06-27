using UnityEngine;

public class CardColletions : MonoBehaviour
{
    [SerializeField] int gridCardsLimit;
    [SerializeField] int cardAmount;
    [SerializeField] GameObject card;
    [SerializeField] GameObject grid;

    void Start()
    {
        GameObject tempGrid = Instantiate(grid,transform);
        for (int i = 0; i < cardAmount; i++)
        {
             
            if(i % gridCardsLimit == 0 && i != 0)
            {
                tempGrid = Instantiate(grid,transform);
                tempGrid.SetActive(false);
            }
            Instantiate(card, tempGrid.transform);
        }

    }

   
   
}
