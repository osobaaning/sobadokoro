using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Title_scene : MonoBehaviour
{
    //public GameObject casinocoin; // 画像のGameObject参照

    private Vector3 upPosition = new Vector3(-5.5f, -2.2f, -1.0f);   // 上の位置
    private Vector3 midolPosition = new Vector3(-5.2f, -3.5f, -1.0f); // 真ん中の位置
    private Vector3 downPosition = new Vector3(-5.2f, -4.5f, -1.0f); // 下の位置

    private int button_num = 0; // 0:上, 1:真ん中, 2:下

    void Start()
    {
        // 初期位置を上に設定
        transform.position = upPosition;
    }

    void Update()
    {
        // 上キーで一段上げる
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            button_num--;
            if (button_num < 0) button_num = 0;
        }
        // 下キーで一段下げる
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            button_num++;
            if (button_num > 2) button_num = 2;
        }

        // 選択位置に応じて座標を変更
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

        // 決定キーでシーン遷移
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
