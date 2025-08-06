using System.Collections.Generic;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    [SerializeField]
    private GameObject cardPrefab;
    [SerializeField]
    public List<GameObject> dealerCards;

    //カードの初期位置と間隔
    [SerializeField]
    private Vector2 firstCardTransform;
    [SerializeField]
    private Vector2 distance;

    //カードを出す間隔
    [SerializeField]
    private float cardTime;

    [SerializeField]
    private int maxCards = 11;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dealerCards = new List<GameObject>();
        startCards();
        Invoke("startCards", cardTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startCards()
    {
        dealerCards.Add(Instantiate(cardPrefab, firstCardTransform + distance * dealerCards.Count, Quaternion.identity));
        //GameObject newCard = Instantiate(cardPrefab, firstCardTransform + distance * myCards.Count, Quaternion.identity);
    }
}
