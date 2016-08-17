using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.UI;

namespace MonterProject
{




    public class GameController : MonoBehaviour
    {
        public GameObject Player;
        private Animator _animator;
        public int TimeRun;
        public Image WorkPlaceImage;
        public GameObject WorkPlaceGameObject;
        public Image Worker;
        public GameObject WorkerGameObject;
        private void Start()
        {}

        void Update()
        {
            SetUIPosition(WorkPlaceImage, WorkPlaceGameObject);
            SetUIPosition(Worker, WorkerGameObject);

        }

        void SetUIPosition(Image itemUi, GameObject target)
        {
            itemUi.transform.position = Camera.main.WorldToScreenPoint(target.transform.position);
        }

        public void iTweenMover()
        {
            _animator = Player.GetComponent<Animator>();
            _animator.SetTrigger("run");
            iTween.MoveTo(Player, iTween.Hash(
                "path", iTweenPath.GetPath("Artem"),
                "time", TimeRun,
                "easetype", iTween.EaseType.linear,
                "orienttopath", true
                ));
        }
    }
}