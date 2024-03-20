using Core;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Presentation
{
    public class ResourceVisual : MonoBehaviour 
    {
        [SerializeField] Core.GameResource typeOfResource;
        [SerializeField] Core.ResourceBank bank;
        [SerializeField] TextMeshProUGUI text;
        void Start()
        {
            if (bank != null)
            {
                Core.ObservableInt resource = bank.GetResource(typeOfResource);
                resource.PropertyChanged += UpdateTextEvent;
                UpdateText(resource.Value);
            }
        }
        void UpdateTextEvent(object observableIntObject, PropertyChangedEventArgs example)
        {
            UpdateText(((ObservableInt)observableIntObject).Value);
        }

        void UpdateText(int value)
        {
            text.text = $"{value}";
        }

    }
    
}
