using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Result_scene : MonoBehaviour
{
    //public GameObject casinocoin; // �摜��GameObject�Q��

    private Vector3 upPosition = new Vector3(-2.73f, -2.25f, -0.1f);   // ��̈ʒu
    private Vector3 downPosition = new Vector3(-2.73f, -3.85f, -0.1f); // ���̈ʒu

    private int button_num = 0;


    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            button_num = 0;
            //if (casinocoin != null)
            transform.position = upPosition;
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            button_num = 1;
            //if (casinocoin != null)
            transform.position = downPosition;
        }
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            if (button_num == 0)
            {
                SceneManager.LoadScene("Main");
            }
            if (button_num == 1)
            {
                SceneManager.LoadScene("Title");
            }
        }
    }
}
