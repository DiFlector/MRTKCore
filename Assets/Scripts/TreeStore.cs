using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TreeStore : MonoBehaviour
{
    [SerializeField] private TextMeshPro text;
    [SerializeField] private PlayerMoney money;
    [SerializeField] public int treeType = 0;
    [SerializeField] public int axeType = 0;
    [SerializeField] private GameObject[] trees;
    [SerializeField] private GameObject[] axes;
    [SerializeField] private Animator animator;
    [SerializeField] private ARMenu menu;
    [SerializeField] private ParticleSystem effect;

    public void chop()
    {
        animator.SetTrigger("ChopTrigger");
    }
    private void updateTreesAndAxes()
    {
        for (int i = 0; i< trees.Length; i++)
        {
            if(i != treeType) {
                trees[i].SetActive(false);
            }else
            {
                trees[i].SetActive(true);
            }
        }

        for (int i = 0; i < axes.Length; i++)
        {
            if (i != axeType)
            {
                axes[i].SetActive(false);
            }
            else
            {
                axes[i].SetActive(true);
            }
        }
    }

    void Update()
    {
        text.text = "Магазин. Доски: " + money._moneyAmount;
        updateTreesAndAxes();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe"))
        {
            effect.Play();
            money._moneyAmount += 10 * (treeType+1) * (axeType+1);
            menu.UpdateButtons();
        }
    }

    public void upTree(int a)
    {
        treeType = a;
    }

    public void upAxe(int a)
    {
        axeType = a;
    }
}
