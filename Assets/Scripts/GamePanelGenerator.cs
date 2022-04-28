using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanelGenerator : MonoBehaviour
{
    [SerializeField] private List<RectTransform> _placesForGame;
    [SerializeField] private RectTransform _gamePanel;

    private void Start()
    {
        RectTransform gamePanel;

        foreach (var panel in _placesForGame)
        {
            gamePanel = Instantiate(_gamePanel, panel);
            gamePanel.gameObject.SetActive(true);
		}
    }
}
