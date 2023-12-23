using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UdemyProject1.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI scoreText;

        private void Awake()
        {
            scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
            HandleOnScoreChanged();
        }

        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
        }

        private void HandleOnScoreChanged(int score = 0)
        {
            scoreText.text = $"Score:{score}";
        }
    }
}

