using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


namespace MonterProject
{
    public class MonterController : PlayerController
    {

        public int TimeWalk;
        private iTweenPath _path;
        public GameObject item;

        public STATEHERO Statehero;
        void Start()
        {
            _path=GetComponent<iTweenPath>();
            Move();
        }

        public override void MethodEndWalk()
        {
            if (item)
            {
                CreateInstrument(item,.3f);
                
            }
        }

        void Move()
        {
            MoveTo(_path.pathName,TimeWalk,Statehero);
        }


    }
}
