using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.UI;

namespace MonterProject
{
    public class GameController : MonoBehaviour
    {
     
        
        /// <summary>
        /// Метод для установки текста над элементом
        /// </summary>
        /// <param name="itemUi"></param>
        /// <param name="target"></param>
        void SetUIPosition(Image itemUi, GameObject target)
        {
            itemUi.transform.position = Camera.main.WorldToScreenPoint(target.transform.position);
            
        }

     
      


    }
}