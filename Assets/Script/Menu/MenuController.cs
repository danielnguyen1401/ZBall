using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button playBtn;
    [SerializeField] Button musicBtn;
    [SerializeField] Sprite disableSprite;
    [SerializeField] Sprite musicEnableSprite;
    const string GO = "https://www.google.com.vn/";

    private bool musicIsOn = true;

    void Awake()
    {
        playBtn.onClick.AddListener(OnPlayClick);
        musicBtn.onClick.AddListener(OnMusicClick);
    }

    void Start()
    {
    }

    void Update()
    {
    }

    void OnPlayClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    void OnRateClick()
    {
        
    }
    void OnMusicClick()
    {
        musicIsOn = !musicIsOn;

        if (!musicIsOn)
        {
            musicBtn.transform.GetChild(1).GetComponent<Image>().sprite = disableSprite;
        }
        else
        {
            musicBtn.transform.GetChild(1).GetComponent<Image>().sprite = musicEnableSprite;
        }
    }
}
