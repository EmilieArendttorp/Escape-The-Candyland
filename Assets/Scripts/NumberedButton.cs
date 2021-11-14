using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberedButton : MonoBehaviour
{
    [SerializeField] TextMeshPro numberText = null;
    [SerializeField] GameObject sign = null;
    [SerializeField] int number = 0;

    static int correctCounter = 0;

    private void Start()
    {
        numberText.text = number.ToString();
    }

    private void OnEnable()
    {
        SceneManager.activeSceneChanged += OnSceneChange;
    }

    private void OnDisable()
    {
        SceneManager.activeSceneChanged -= OnSceneChange;
    }

    void OnSceneChange(Scene scene, Scene scene1)
    {
        correctCounter = 0;
    }

    //Unity Event reaction.
    public void IsCorrectButton(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            if (sign != null && sign.gameObject.activeSelf)
            {
                correctCounter++;
                sign = null;

                if(correctCounter == 3)
                {
                    OnPuzzleCompletion();
                }
            }
        }
    }

    void OnPuzzleCompletion()
    {
        transform.root.gameObject.SetActive(false);
        FindObjectOfType<GesturePuzzleManager>().NumberedButtonsCompletion();   
    }
}
