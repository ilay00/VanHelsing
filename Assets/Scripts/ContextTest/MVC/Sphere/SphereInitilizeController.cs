﻿using System;
using UnityEngine;


namespace BeastHunter
{
    public sealed class SphereInitilizeController : IAwake
    {

        #region Field
       
        GameContext _context;
        

        #endregion


        #region ClassLifeCycle

        public SphereInitilizeController(GameContext context, Services services)
        {
            _context = context;
           
        }

        #endregion


        #region IAwake




        public void TimeSpn()
        {
            var SphereData = Data.SphereData;
            GameObject instance = GameObject.Instantiate(SphereData.SphereStruct.Prefab);
            SphereModel Sphere = new SphereModel(instance, SphereData);
            _context._sphereModel = Sphere;
           
        }



        public void OnAwake()
        {

           

            //  var TimeRemaining = new TimeRemaining(TimeSpn, 0.1f, false);



            TimeSpn();





        }
     

        #endregion
    }
}


