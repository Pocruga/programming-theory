using UnityEngine;
using TMPro;

namespace Pocruga.OOPT.CharacterWizard
{
    public class AbilityScoreHandler : MonoBehaviour
    {
        [SerializeField]
        private AbilityInputHandler[] abilities;

        [SerializeField]
        private TMP_InputField availableAbilityPoints;

        private int MaxAbilityPoints { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            MaxAbilityPoints = GetMaxAbilityPoints(true);

            foreach (var ability in abilities)
            {
                ability.OnAbilityScoreChanged += EnsureMaxAbilityPoints;
            }
        }

        private void EnsureMaxAbilityPoints(bool incremented)
        {
            int currentAvailablePoints = GetAvailableAbilityPoints();

            if (currentAvailablePoints > 0 && incremented)
            {
                availableAbilityPoints.text = (currentAvailablePoints - 1).ToString();
                if(currentAvailablePoints == 1)
                    SetMaxAbilityPointsReached(true);
            }
            
            if (currentAvailablePoints >= 0 && !incremented)
            {
                if (currentAvailablePoints == 0)
                    SetMaxAbilityPointsReached(false);
                availableAbilityPoints.text = (currentAvailablePoints + 1).ToString();
            }
        }

        // dice the maximum availability points according to the ruleset or get the fast default of 12
        private int GetMaxAbilityPoints(bool dice)
        {
            if (dice)
            {
                // TODO implement origin dicing rules
                // dice a 3W6 for each ability (value between 3 and 18) and
                // sum of ability modifiers gets greater than +3
                // otherwise repeat the procedure

                // simplified implementation
                int max = Random.Range(6, 18);
                availableAbilityPoints.text = max.ToString();
                return max;
            } else // simplified quick selection variant
                return 12;
        }

        private void SetMaxAbilityPointsReached(bool reached)
        {
            foreach (var ability in abilities)
                ability.ThreshholdReached = reached;

            Debug.Log("limit reached: " + reached);
        }

        private int GetAvailableAbilityPoints() {
            if (string.IsNullOrEmpty(availableAbilityPoints.text))
                return MaxAbilityPoints;
            return int.Parse(availableAbilityPoints.text);
        }
    }
}
