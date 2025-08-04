using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Button_1 : MonoBehaviour
{
    //public GameObject casinocoin; // �摜��GameObject�Q��

    private Vector3 upPosition = new Vector3(-5.5f, -2.2f, -1.0f);   // ��̈ʒu
    private Vector3 downPosition = new Vector3(-5.5f, -3.5f, -1.0f); // ���̈ʒu

    private int button_num = 0;

    void Start()
    {
        // �����ʒu�����ɐݒ�
        //if (casinocoin != null)
        //    casinocoin.transform.position = downPosition;
    }

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
                SceneManager.LoadScene("Rule");
            }
        }
    }
}
