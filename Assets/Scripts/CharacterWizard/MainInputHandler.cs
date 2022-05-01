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
        private TMP_Text displayText;

        [SerializeField]
        private TMP_Dropdown raceDropdown;

        [SerializeField]
        private TMP_Dropdown subChoiceDropdown;

        [SerializeField]
        private TMP_Dropdown themeDropdown;
        
        [SerializeField]
        private TMP_Dropdown classDropdown;

        void Start() {
            subChoiceDropdown.enabled = false;
            subChoiceDropdown.interactable = false;
        }

        // Start is called before the first frame update
        public void HandleRaceInput()
        {
            IRace race = RaceFactory.GetRace(raceDropdown.captionText.text);
            if (race != null)
            {
                displayTitle.text = string.Format("Race {0}", race.Title);
                displayText.text = race.Description;

                if(race.HasAdditionalSelection())
                {
                    subChoiceDropdown.ClearOptions();
                    subChoiceDropdown.AddOptions(RaceFactory.GetSubChoiceElements(race));
                    subChoiceDropdown.value = -1;
                    subChoiceDropdown.RefreshShownValue();
                    subChoiceDropdown.enabled = true;
                    subChoiceDropdown.interactable = true;
                } else {
                    subChoiceDropdown.ClearOptions();
                    subChoiceDropdown.enabled = false;
                    subChoiceDropdown.interactable = false;
                }
            }
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

        }

    }
}
