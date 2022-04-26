using UnityEngine;
using TMPro;

namespace Pocruga.OOPT.CharacterWizard
{
    public class MainInputHandler : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text displayTitle;

        [SerializeField]
        private TMP_Text displayText;

        [SerializeField]
        private TMP_Dropdown raceDropdown;

        // Start is called before the first frame update
        public void HandleRaceInput()
        {
            displayTitle.text = string.Format("Race {0}", raceDropdown.captionText.text);
        }
    }
}
