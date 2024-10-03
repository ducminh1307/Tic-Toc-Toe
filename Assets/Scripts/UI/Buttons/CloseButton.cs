using UnityEngine;
using UnityEngine.Serialization;

public class CloseButton : BaseButton
{
    [SerializeField] private UIType typeType;
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(typeType).Hide();
    }
}