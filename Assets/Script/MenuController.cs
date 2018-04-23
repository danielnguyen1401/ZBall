using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button playBtn;
    [SerializeField] Button musicBtn;
    [SerializeField] Sprite disableSprite;
    [SerializeField] Sprite musicEnableSprite;

    private bool musicIsOn = true;

    void Awake()
    {
        playBtn.onClick.AddListener(OnPlayClick);
        musicBtn.onClick.AddListener(OnMusicClick);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnPlayClick()
    {
        Debug.Log("Play");
    }

    void OnMusicClick()
    {
//        Debug.Log("Music");
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
