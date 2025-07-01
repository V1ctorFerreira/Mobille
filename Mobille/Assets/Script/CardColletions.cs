using UnityEngine;
using UnityEngine.UI;

public class CardColletions : MonoBehaviour
{
    [SerializeField][Min(1)] int gridCardsLimit;
    [SerializeField][Min(0)] int cardAmount;
    [SerializeField] GameObject card;
    [SerializeField] GameObject grid;

    [SerializeField] Button nextPage;
    [SerializeField] Button previusPage;
    GridLayoutGroup[] collectionPages;
    int pageseIndex;
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
        collectionPages = GetComponentsInChildren<GridLayoutGroup>(true);
        ActiveUIElement();
        nextPage.onClick.AddListener(delegate
        {
            CollectionNavigate(1);
        });
        previusPage.onClick.AddListener(delegate
        {
            CollectionNavigate(-1);
        });






    }

    public void CollectionNavigate(int value)
    {
        collectionPages[pageseIndex].gameObject.SetActive(false);
        pageseIndex += value;

        if(pageseIndex >= collectionPages.Length)
             pageseIndex = 0;


        if(pageseIndex < 0)
            pageseIndex = collectionPages.Length - 1;

        collectionPages[pageseIndex].gameObject.SetActive(true);
    }

    void ActiveUIElement()
    {
        nextPage.gameObject.SetActive(true);
        previusPage.gameObject.SetActive(true);
    }
    

   
   
}
