using UnityEngine;

public class Deck : MonoBehaviour
{
    public bool[,] deck = new bool[4, 13];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Initialization();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Initialization()
    {
        for (int i = 0; i < deck.GetLength(0); i++)
        {
            for (int j = 0; j < deck.GetLength(1); j++)
            {
                deck[i, j] = true;
            }
        }
    }
    public void decknow(int mark, int number)
    {
        deck[mark, number - 1] = false;
    }
}
