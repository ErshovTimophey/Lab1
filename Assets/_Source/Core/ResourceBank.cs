using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UnityEngine;


namespace Core 
{
    public class ResourceBank : MonoBehaviour {
         public Dictionary<Core.GameResource, ObservableInt> resources_map = new Dictionary<Core.GameResource, ObservableInt>();
         public void ChangeRecources(Core.GameResource resource, int value)
        {
            resources_map[resource].Value += value;
        }
        public ObservableInt GetResource(Core.GameResource resource)
        {
            return resources_map[resource];
        }
        
    }
    
}
