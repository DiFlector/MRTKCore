using System;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;

    [SerializeField] private TextMeshPro _title;

    [SerializeField] private Interactable _interactable;

    private GameObject _prefab;

    public GameObject[] spawnpoint;
    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.Prefab;
        spawnpoint = GameObject.FindGameObjectsWithTag("Spawnpoint");

        _interactable.OnClick.AddListener(ProcessClick);
    } 

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        Instantiate(_prefab, new Vector3(spawnpoint[0].transform.position.x, 0f, spawnpoint[0].transform.position.z), Quaternion.identity);  
    }
}