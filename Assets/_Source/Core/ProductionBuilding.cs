using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] public float productionTime;
        [SerializeField] Core.GameResource resource;

        [SerializeField] Core.ResourceBank bank;
        [SerializeField] Button button;
         [SerializeField]  Slider progressSlider;
         [SerializeField] Core.ProductionBuilding productionBuilding;
         private bool Running = false;

        
        public void Increase(){
            if (!Running)
            {
                Running = true;
                button.interactable = false;
                StartCoroutine(ProductionBuildingCoroutine());
            }
            
        }
        IEnumerator ProductionBuildingCoroutine()
        {
            
              float timeWasted = 0f;
            progressSlider.value = 0f;

            progressSlider.gameObject.SetActive(true);

            while (timeWasted < productionTime)
            {
                timeWasted += Time.deltaTime;    
                progressSlider.value = timeWasted / productionTime; 
                yield return null; 
            }
            bank.ChangeRecources(resource, 1);
            Running = false;
            button.interactable = true;
            
        }
        public void riseLevel()
        {
            bank.ChangeRecources(resource, 10);
            productionBuilding.productionTime = 1f - (float)bank.resources_map[resource].Value / 100f;
        }
    }
}