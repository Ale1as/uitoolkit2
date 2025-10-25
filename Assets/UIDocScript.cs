using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIDocScript : MonoBehaviour
{
    [SerializeField] UIDocument uIDocument;
    private VisualElement root;
    private Label Header;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        root = uIDocument.rootVisualElement;

        var playbtn = root.Q<VisualElement>("play");
        playbtn.RegisterCallback<ClickEvent>(PlaybtnEvent);
        var optionbtn = root.Q<VisualElement>("options");
        var quitbtn = root.Q<VisualElement>("Exit");
        optionbtn.RegisterCallback<ClickEvent>(OptionsbtnEvent);
        quitbtn.RegisterCallback<ClickEvent>(QuitbtnEvent);
        Header = root.Q<Label>("Title");
    }

    private void PlaybtnEvent(ClickEvent evt)
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }
        private void OptionsbtnEvent(ClickEvent evt)
    {
        Debug.Log("options");
        Header.text = "Options";
    }
        private void QuitbtnEvent(ClickEvent evt)
    {
        Debug.Log("quit");

    }
}

