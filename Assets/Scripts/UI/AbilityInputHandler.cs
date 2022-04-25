using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Pocruga.OOPT.UI
{
    public class AbilityInputHandler : MonoBehaviour
    {
        private const int DEFAULT_SCORE = 10;

        [SerializeField]
        private TMP_InputField scoreInputField;

        [SerializeField]
        private TMP_InputField modifierInputField;

        /// <summary>
        /// The action informs about an ability score change and the direction
        /// <code>true</code> if incremented; <code>false</code> otherwise
        /// </summary>
        public event Action<bool> OnAbilityScoreChanged;

        // indicates whether this ability is a key ability of the character
        public bool KeyAbility { get; set; }

        public bool ThreshholdReached { get; set; }

        // increment score value by one with the plus button click 
        public void IncrementScore()
        {
            int value = GetCurrentScore() + 1;
            if (value <= 30 && !ThreshholdReached)
                ChangeScore(value, true);
        }

        // decrement score value by one with the minus button click 
        public void DecrementScore()
        {
            int value = GetCurrentScore() - 1;

            if (value >= 0)
                ChangeScore(value, false);
        }

        // Change current ability score and inform others about the change direction
        // true if incremented; false otherwise
        private void ChangeScore(int value, bool direction)
        {
            scoreInputField.text = value.ToString();
            SetModifier(value);
            OnAbilityScoreChanged?.Invoke(direction);
        }

        private int GetCurrentScore()
        {
            if (string.IsNullOrEmpty(scoreInputField.text))
                return DEFAULT_SCORE;
            return int.Parse(scoreInputField.text);
        }

        // set modifier value that belongs to the score value
        private void SetModifier(int value)
        {
            modifierInputField.text = (Mathf.FloorToInt(value / 2) - 5).ToString();
        }
    }
}
