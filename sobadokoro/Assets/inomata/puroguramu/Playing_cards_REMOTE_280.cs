using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using sei;

public class Aceof : MonoBehaviour
{
    public enum Mark
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    public Mark mark { get; private set; }
    public int number { get; private set; }

    private CardGraphics cardGraphics;
    private SpriteRenderer spriteRenderer;
    private Distribute distribute;
    private Deck deckManager;
    //引いたカードのマークと番号を保持する変数
    private int derowMark;
    private int derowNumber;
    private bool[,] deck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //山札の取得
        deckManager = GameObject.Find("DeckManager").GetComponent<Deck>();
        deck = deckManager.deck;
        distribute = GameObject.Find("DistributeManager").GetComponent<Distribute>();

        cardGraphics = GameObject.Find("CardManager").GetComponent<CardGraphics>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        while(true)
        {
            derowMark = Random.Range(0, 4);
            derowNumber = Random.Range(1, 14);
            if (deck[derowMark, derowNumber - 1])
            {
                deck[derowMark, derowNumber - 1] = false;
                break;
            }
        }
        SetType((Mark)derowMark, derowNumber);
        deckManager.decknow(derowMark, derowNumber);
        for (int i = 0; i < deck.GetLength(0); i++)
        {
            for (int j = 0; j < deck.GetLength(1); j++)
            {
                Debug.Log(deck[i, j] + ",");
            }
        }
    }

    public void SetType(Mark mark, int number)
    {
        this.mark = mark;
        this.number = number;
        spriteRenderer.sprite = cardGraphics.GetCardSprite(mark, number);
        spriteRenderer.sortingOrder = distribute.myCards.Count + 1;
    }
}
