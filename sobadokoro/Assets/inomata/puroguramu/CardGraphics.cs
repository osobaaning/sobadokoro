
using UnityEngine;

public class CardGraphics : MonoBehaviour
{
    [SerializeField]
    private Sprite[] card;

    public Sprite GetCardSprite(Aceof.Mark mark, int number)
    {
        return card[(int)mark * 13 + (number - 1)];
    }
}
