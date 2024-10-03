using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class BasePanel : MonoBehaviour
{
    protected CanvasGroup CanvasGroup;
    protected UIType PanelType;

    protected virtual void Awake()
    {
        CanvasGroup = GetComponent<CanvasGroup>();
        UIManager.Instance.RegisterPanel(this, PanelType);
    }

    public virtual void OnAwake()
    {
        Deactivate();
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        Deactivate();
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
