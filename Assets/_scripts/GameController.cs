using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.UI;

namespace MonterProject
{
    public class GameController : MonoBehaviour
    {
        
        public GameObject Player;
        public Image WorkPlaceImage;
        public GameObject WorkPlaceGameObject;
        public Image Worker;
        public GameObject WorkerGameObject;

        private void Start()
        {
        
        }

        void Update()
        {
            SetUIPosition(WorkPlaceImage, WorkPlaceGameObject);
            SetUIPosition(Worker, WorkerGameObject);
        }


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