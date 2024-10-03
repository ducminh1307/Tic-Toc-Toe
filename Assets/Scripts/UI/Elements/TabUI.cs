using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabUI : MonoBehaviour
{
    [Header("Button Color")]
    [SerializeField] private Color _activeButtonColor;
    [SerializeField] private Color _inactiveButtonColor;
    
    [Header("Text Color")]
    [SerializeField] private Color _activeTextColor;
    [SerializeField] private Color _inactiveTextColor;
    
    [Header("UI Elements")]
    [SerializeField] private List<Button> _tabButtons;
    [SerializeField] private List<GameObject> _tabContents;
    private List<Image> _tabButtonImages = new List<Image>();
    private List<TextMeshProUGUI> _tabTexts = new List<TextMeshProUGUI>();

    private void Start()
    {
        InitTab();

        SwitchTab();
    }

    private void InitTab()
    {
        for (int i = 0; i < _tabButtons.Count; i++)
        {
            var tabIndex = i;
            _tabButtons[i].onClick.AddListener(() => SwitchTab(tabIndex));
            _tabButtonImages.Add(_tabButtons[i].GetComponent<Image>());
            _tabTexts.Add(_tabButtons[i].GetComponentInChildren<TextMeshProUGUI>());
        }
    }

    private void SwitchTab(int tabIndex = 0)
    {
        for (int i = 0; i < _tabButtons.Count; i++)
        {
            _tabButtonImages[i].color = (i == tabIndex) ? _activeButtonColor : _inactiveButtonColor;
            _tabTexts[i].color = (i == tabIndex) ? _activeTextColor : _inactiveTextColor;
            _tabContents[i].SetActive(i == tabIndex);
        }
    }
}