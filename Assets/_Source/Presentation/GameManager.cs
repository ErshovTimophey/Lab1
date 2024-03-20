using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Core.ResourceBank recouce_bank;
        private void Awake()
        {
            recouce_bank.resources_map.Add(Core.GameResource.Humans, new Core.ObservableInt(10));
            recouce_bank.resources_map.Add(Core.GameResource.Food, new Core.ObservableInt(5));
            recouce_bank.resources_map.Add(Core.GameResource.Wood, new Core.ObservableInt(5));
            recouce_bank.resources_map.Add(Core.GameResource.Stone, new Core.ObservableInt(0));
            recouce_bank.resources_map.Add(Core.GameResource.Gold, new Core.ObservableInt(0));
            recouce_bank.resources_map.Add(Core.GameResource.HumansProdLvl, new Core.ObservableInt(1));
            recouce_bank.resources_map.Add(Core.GameResource.FoodProdLvl, new Core.ObservableInt(1));
            recouce_bank.resources_map.Add(Core.GameResource.WoodProdLvl, new Core.ObservableInt(1));
            recouce_bank.resources_map.Add(Core.GameResource.StoneProdLvl, new Core.ObservableInt(1));
            recouce_bank.resources_map.Add(Core.GameResource.GoldProdLvl, new Core.ObservableInt(1));
        }
    }
}