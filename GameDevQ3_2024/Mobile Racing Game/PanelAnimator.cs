using UnityEngine;
using System.Collections;

public class PanelsAnimator : MonoBehaviour
{
    public RectTransform leftPanel;
    public RectTransform rightPanel;
    public float moveDuration = 1.0f; // Duration of the move in seconds
    public Vector2 leftPanelTargetPosition; // Target position for the left panel
    public Vector2 rightPanelTargetPosition; // Target position for the right panel

    public GameObject PanelLost;

    void Start()
    {
        MovePanelsToCenter();
    }

    // Call this method when you want to move the panels
    public void MovePanelsToCenter()
    {
        StartCoroutine(MovePanel(leftPanel, leftPanelTargetPosition, moveDuration));
        StartCoroutine(MovePanel(rightPanel, rightPanelTargetPosition, moveDuration));
    }

    private IEnumerator MovePanel(RectTransform panel, Vector2 targetPosition, float duration)
    {
        Vector2 startPosition = panel.anchoredPosition;
        float time = 0;

        while (time < duration)
        {
            time += Time.deltaTime;
            panel.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, time / duration);
            yield return null;
        }

        panel.anchoredPosition = targetPosition; // Ensure the panel is exactly at the target position when done

        PanelLost.SetActive(true);
    }
}
