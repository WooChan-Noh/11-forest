using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UI : MonoBehaviour
{

    public Image forest;
    public Image river;
    public Image sea;
    public Image nightForest;
    public Image roadSide;

    public Button menuButton;
    public Button forestButton;
    public Button riverButton;
    public Button seaButton;
    public Button nightForestButton;
    public Button roadSideButton;

    private bool isImageActive = true;
    private bool isButtonActive = true;
 
    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        menuButton.onClick.AddListener(ToggleImage);
        forestButton.onClick.AddListener(() => ButtonClick(forestButton));
        riverButton.onClick.AddListener(()=>ButtonClick(riverButton));
        seaButton.onClick.AddListener(() => ButtonClick(seaButton));
        nightForestButton.onClick.AddListener(() => ButtonClick(nightForestButton));
        roadSideButton.onClick.AddListener(() => ButtonClick(roadSideButton));
    }
    public void ButtonClick(Button button)
    {
        switch (button.name)
        {
            case "forestButton":
                SceneManager.LoadScene("1.Forest");
                break;
            case "riverButton":
                SceneManager.LoadScene("2.River");
                break;
            case "seaButton":
                SceneManager.LoadScene("3.Sea");
                break;
            case "nightButton":
                SceneManager.LoadScene("4.Night");
                break;
            case "roadButton":
                SceneManager.LoadScene("5.RoadSide");
                break;
            default:         
                break;
        }
    }

    public void ToggleImage()
    {
        forest.gameObject.SetActive(isImageActive);
        nightForest.gameObject.SetActive(isImageActive);
        river.gameObject.SetActive(isImageActive);
        sea.gameObject.SetActive(isImageActive);
        roadSide.gameObject.SetActive(isImageActive);
        isImageActive = !isImageActive;

  
        forestButton.gameObject.SetActive(isButtonActive);
        nightForestButton.gameObject.SetActive(isButtonActive);
        riverButton.gameObject.SetActive(isButtonActive);
        seaButton.gameObject.SetActive(isButtonActive);
        roadSideButton.gameObject.SetActive(isButtonActive);
        isButtonActive = !isButtonActive;
    }
    

}
