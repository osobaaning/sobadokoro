using sei;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private Distribute distribute;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            distribute.hit();
        }
        if(Keyboard.current.enterKey.wasPressedThisFrame)
        {
            distribute.ClearDeck();
        }
    }
}
