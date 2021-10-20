using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    [SerializeField] MeshRenderer mesh = null;
    public bool isAnswer = false;

    Material material = null;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    public void SetColor(Color color)
    {
        mesh.material.color = color;
        material.color = color;
    }

    public Color GetColor()
    {
        return material.color;
    }
}