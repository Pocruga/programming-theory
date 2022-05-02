using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using TMPro;

using Pocruga.OOPT.CharacterSheet.Race;

namespace Pocruga.OOPT.CharacterWizard
{
    public class MainInputHandler : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text displayTitle;

        [SerializeField]
        private Text displayText;

        [SerializeField]
        private TMP_Dropdown raceDropdown;

        [SerializeField]
        private TMP_Dropdown subChoiceDropdown;

        [SerializeField]
        private TMP_Dropdown themeDropdown;
        
        [SerializeField]
        private TMP_Dropdown classDropdown;

        void Start() {
            ActivateRaceSubSelection(false);
            // reset display text
            displayTitle.text = "Select character property";
            SetDisplayText(string.Empty);
        }

        // Start is called before the first frame update
        public void HandleRaceInput()
        {
            IRace race = RaceFactory.GetRace(raceDropdown.captionText.text);
            if (race != null)
            {
                displayTitle.text = string.Format("Race {0}", race.Title);
                SetDisplayText(race.DisplayText);
                ActivateRaceSubSelection(race);
            }
        }

        private void SetDisplayText(string text) {
            displayText.text = text;
        }

        private void ActivateRaceSubSelection(IRace race) {
            ActivateRaceSubSelection(race.HasAdditionalSelection());

            if(race.HasAdditionalSelection()) {
                subChoiceDropdown.AddOptions(RaceFactory.GetSubChoiceElements(race));
            }
            subChoiceDropdown.RefreshShownValue();
        }

        private void ActivateRaceSubSelection(bool enable) {
            subChoiceDropdown.ClearOptions();
            TextMeshProUGUI placeholder = (TextMeshProUGUI)subChoiceDropdown.placeholder;
            placeholder.gameObject.SetActive(enable);
            subChoiceDropdown.enabled = enable;
            subChoiceDropdown.interactable = enable;
        }

        public void HandleThemeInput()
        {
            displayTitle.text = string.Format("Theme {0}", themeDropdown.captionText.text);
        }

        public void HandleClassInput()
        {
            displayTitle.text = string.Format("Class {0}", classDropdown.captionText.text);
        }

        public void HandleAdditionalInputForRace() {
            IRace race = RaceFactory.GetRace(raceDropdown.captionText.text, subChoiceDropdown.captionText.text);
            if (race != null)
            {
                displayTitle.text = string.Format("Race {0}", race.Title);
                SetDisplayText(race.DisplayText);
            }
        }

    }
}
