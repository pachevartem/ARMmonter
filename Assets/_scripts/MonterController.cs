using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;


namespace MonterProject
{
    public class MonterController : PlayerController
    {

        public int TimeWalk;
        private iTweenPath _path;

        void Start()
        {
            _path=GetComponent<iTweenPath>();
            Move();
        }

        public override void MethodEndWalk()
        {
            print("я дошел" + gameObject.name);
        }

        void Move()
        {
            MoveTo(_path.pathName,TimeWalk);
        }


    }
}
