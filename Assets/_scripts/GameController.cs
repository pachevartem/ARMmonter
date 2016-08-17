using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

namespace MonterProject
{


    public class GameController : MonoBehaviour
    {
        public GameObject Player;
        public iTweenPath Path;
        private Animator _animator;
        public int TimeRun;
        private void Start()
        {
            _animator = Player.GetComponent<Animator>();
            _animator.SetTrigger("run");
            iTween.MoveTo(Player, iTween.Hash(
                "path", iTweenPath.GetPath("Artem"),
                "time", TimeRun, 
                "easetype",iTween.EaseType.linear,
                "orienttopath", true
                ));


        }
    }
}