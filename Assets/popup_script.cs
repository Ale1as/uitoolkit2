using UnityEngine;
using UnityEngine.UIElements;

public class popup_script : MonoBehaviour
{
    private VisualElement _bottomContainer;
    private Button _openButton;
    private Button _closeButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        _bottomContainer = root.Q<VisualElement>("bottom_container");
        _openButton = root.Q<Button>("open_button");
        _closeButton = root.Q<Button>("exit_button");

        _bottomContainer.style.display = DisplayStyle.None;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
