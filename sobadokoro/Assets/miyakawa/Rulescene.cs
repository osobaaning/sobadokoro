using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Rule_scene : MonoBehaviour
{
    //public GameObject casinocoin; // �摜��GameObject�Q��

    private Vector3 upPosition = new Vector3(-5.5f, -2.2f, -1.0f);   // ��̈ʒu
    private Vector3 downPosition = new Vector3(-5.5f, -3.5f, -1.0f); // ���̈ʒu

    private int button_num = 0;

    void Update()
    {

        if (Keyboard.current.enterKey.wasPressedThisFrame)

            {
                SceneManager.LoadScene("Title");
            }
    }
}