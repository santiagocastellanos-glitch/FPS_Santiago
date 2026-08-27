using System.Threading;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    public static gameManagerScript instance;

    public bool isPlaying;

    [SerializeField]
    private float GameTime;

    [SerializeField]
    private TMP_Text timerText;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
       if(GameTime > 0)
        {
            GameTime -= Time.deltaTime;
            float min = (int)GameTime / 60;
            float seg = (int)GameTime % 60;
            timerText.text = min.ToString("00") + ":" + seg.ToString("00");
        }
       if(GameTime <= 0)
        {
            isPlaying = false;
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
