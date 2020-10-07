using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button dealButton;
    public Button hitButton;
    public Button standButton;
    public Button betButton;

    void Start()
    {
        dealButton.onClick.AddListener(() => DealClicked());
        hitButton.onClick.AddListener(() => HitClicked());
        standButton.onClick.AddListener(() => StandClicked());
    }

    void DealClicked()
    {
        throw new NotImplementedException();
    }

    void HitClicked()
    {
        throw new NotImplementedException();
    }

    void StandClicked()
    {
        throw new NotImplementedException();
    }
}
