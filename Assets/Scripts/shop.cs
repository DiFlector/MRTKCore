using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] public TextMeshPro text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wood"))
        {
            text.text = "Магазин. Доски: " + _playerMoney._moneyAmount;
            _playerMoney._moneyAmount += 5;
            Destroy(other.gameObject);
        }
    }
}
