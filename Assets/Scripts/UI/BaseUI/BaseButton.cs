using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BaseButton : MonoBehaviour
{
    private Button button;
    private void Awake()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(OnClick);
    }

    protected virtual void OnClick()
    {

    }
}