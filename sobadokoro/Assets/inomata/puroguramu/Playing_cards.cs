using UnityEngine;

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cardGraphics = GameObject.Find("CardManager").GetComponent<CardGraphics>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        SetType(Mark.Clubs, 1);
    }

    public void SetType(Mark mark, int number)
    {
        this.mark = mark;
        this.number = number;
        spriteRenderer.sprite = cardGraphics.GetCardSprite(mark, number);
    }
}
