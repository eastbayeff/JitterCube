using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomButtonPosition : MonoBehaviour
{
    private void OnEnable()
    {
        // Get the canvas that the RectTransform belongs to
        var canvas = GetComponentInParent<Canvas>();

        // Get the RectTransform component
        var rectTransform = GetComponent<RectTransform>();

        // Get the dimensions of the canvas
        var canvasWidth = canvas.GetComponent<RectTransform>().rect.width;
        var canvasHeight = canvas.GetComponent<RectTransform>().rect.height;

        // Calculate a random position within the canvas
        var x = Random.Range(-canvasWidth / 2f, canvasWidth / 2f);
        var y = Random.Range(-canvasHeight / 2f, canvasHeight / 2f);

        // Set the position of the RectTransform to the random position within the canvas
        rectTransform.anchoredPosition = new Vector2(x, y);
    }
}
