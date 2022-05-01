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
        private TextMeshProUGUI displayText;

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
        }

        // Start is called before the first frame update
        public void HandleRaceInput()
        {
            IRace race = RaceFactory.GetRace(raceDropdown.captionText.text);
            if (race != null)
            {
                displayTitle.text = string.Format("Race {0}", race.Title);
                SetDisplaytext(race.DisplayText);
                ActivateRaceSubSelection(race);
            }
        }

        private void SetDisplaytext(string text) {
            displayText.SetText(text);
            Canvas.ForceUpdateCanvases();

            // RectTransform rt = displayText.GetComponent<RectTransform>();
            // Vector3 curPos = rt.transform.position;
            // Debug.Log($"display text height is = {rt.rect.height}");

            displayText.ForceMeshUpdate(true, true);

            // float newY = (Mathf.Round(rt.rect.height/2)*-1) - 2f;
            // Debug.Log($"move text to new y: {newY}");
            // displayText.transform.position = new Vector3(curPos.x , newY, curPos.z);
            // Canvas.ForceUpdateCanvases();

            //Debug.Log($"old posiiton y is {displayText.transform.position.y}");
            // Vector3 position = displayText.transform.position;
            // displayText.transform.position = Vector3.up * displayText.bounds.size.x/2*-1;
            // Debug.Log($"new posiiton y is {displayText.transform.position.y}");
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
                SetDisplaytext(race.DisplayText);
            }
        }

    }
}
