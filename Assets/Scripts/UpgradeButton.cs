using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] private ARMenu menu_;
    [SerializeField] private PlayerMoney money;
    [SerializeField] public int price;
    [SerializeField] private TreeStore treeStore_;
    [SerializeField] private TextMeshPro text;

    [SerializeField] public string type;
    [SerializeField] public int level;

    public void Buy()
    {
        if (money._moneyAmount >= price) {

            if (type == "tree")
            {
                if (treeStore_.treeType < level)
                {
                    treeStore_.treeType = level;
                }
            }
            else if (type == "axe")
            {
                if (treeStore_.axeType < level)
                {
                    treeStore_.axeType = level;
                }
            }
            
            money._moneyAmount -= price;
            text.text = "Магазин. Доски: " + money._moneyAmount;
            menu_.UpdateButtons();
            Destroy(gameObject);
        }
        
    }
}
