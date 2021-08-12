using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Animator))]
public class Button : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void OnButtonClick()
    {
        _animator.SetTrigger("OnCasts");
    }
}
