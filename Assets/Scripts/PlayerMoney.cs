
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] public int _moneyAmount;

    public void ProcessBuy(int money)
    {
        if(_moneyAmount - money < 0)
        {
            return;
        }

        _moneyAmount -= money;
    }

    public bool CanBuy(int price)
    {
        return _moneyAmount - price >= 0;
    }
}
