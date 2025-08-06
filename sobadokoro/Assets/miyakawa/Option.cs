using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    private Vector3 Position1 = new Vector3(0.39f, -1.5f, -1.0f);
    private Vector3 Position2 = new Vector3(1.79f, -1.5f, -1.0f); 
    private Vector3 Position3 = new Vector3(3.66f, -1.5f, -1.0f); 
    private Vector3 Position4 = new Vector3(5.01f, -1.5f, -1.0f);
    private Vector3 Position5 = new Vector3(6.52f, -1.5f, -1.0f);

    private int button_num = 1; // デフォルトはPosition2

    void Start()
    {
        // 保存された音量設定がなければcase1（0.25）で開始
        if (!PlayerPrefs.HasKey("Volume"))
        {
            button_num = 1;
            SetVolume(button_num);
        }
        else
        {
            float savedVolume = PlayerPrefs.GetFloat("Volume", 0.25f);
            button_num = VolumeToButtonNum(savedVolume);
            SetVolume(button_num);
        }

        // 選択位置に応じて座標を変更
        switch (button_num)
        {
            case 0: transform.position = Position1; break;
            case 1: transform.position = Position2; break;
            case 2: transform.position = Position3; break;
            case 3: transform.position = Position4; break;
            case 4: transform.position = Position5; break;
        }
    }

    void Update()
    {
        bool changed = false;

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            button_num--;
            if (button_num < 0) button_num = 0;
            changed = true;
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            button_num++;
            if (button_num > 4) button_num = 4;
            changed = true;
        }

        // 選択位置に応じて座標を変更
        switch (button_num)
        {
            case 0: transform.position = Position1; break;
            case 1: transform.position = Position2; break;
            case 2: transform.position = Position3; break;
            case 3: transform.position = Position4; break;
            case 4: transform.position = Position5; break;
        }

        // 音量を変更し、保存
        if (changed)
        {
            SetVolume(button_num);
            PlayerPrefs.SetFloat("Volume", AudioListener.volume);
            PlayerPrefs.Save();
        }

        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Title");
        }
    }

    // button_numに応じて音量を設定
    void SetVolume(int num)
    {
        float[] volumes = { 0.0f, 0.25f, 0.5f, 0.75f, 1.0f };
        AudioListener.volume = volumes[num];
    }

    // 保存された音量値からbutton_numを復元
    int VolumeToButtonNum(float volume)
    {
        if (volume <= 0.0f) return 0;
        if (volume <= 0.25f) return 1;
        if (volume <= 0.5f) return 2;
        if (volume <= 0.75f) return 3;
        return 4;
    }
}
