﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace No_Mountain_Snow
{
    public class ByeSnow
    {
        public void Start()
        {
            GameObject.Find("snow (1)").SetActive(false);
        }
    }
}
