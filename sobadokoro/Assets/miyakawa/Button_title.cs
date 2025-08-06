using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Title_scene : MonoBehaviour
{
    //public GameObject casinocoin; // �摜��GameObject�Q��

    private Vector3 upPosition = new Vector3(-5.5f, -2.2f, -1.0f);   // ��̈ʒu
    private Vector3 midolPosition = new Vector3(-5.2f, -3.5f, -1.0f); // �^�񒆂̈ʒu
    private Vector3 downPosition = new Vector3(-5.2f, -4.5f, -1.0f); // ���̈ʒu

    private int button_num = 0; // 0:��, 1:�^��, 2:��

    void Start()
    {
        // �����ʒu����ɐݒ�
        transform.position = upPosition;
    }

    void Update()
    {
        // ��L�[�ň�i�グ��
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            button_num--;
            if (button_num < 0) button_num = 0;
        }
        // ���L�[�ň�i������
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            button_num++;
            if (button_num > 2) button_num = 2;
        }

        // �I���ʒu�ɉ����č��W��ύX
        switch (button_num)
        {
            case 0:
                transform.position = upPosition;
                break;
            case 1:
                transform.position = midolPosition;
                break;
            case 2:
                transform.position = downPosition;
                break;
        }

        // ����L�[�ŃV�[���J��
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
            if (button_num == 2)
            {
                SceneManager.LoadScene("Option");
            }
        }
    }
}
