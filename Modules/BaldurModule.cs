﻿using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using KorzUtils.Helper;
using Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TheHuntIsOn.Modules.HealthModules;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheHuntIsOn.Modules;

internal class BaldurModule : Module
{
    #region Properties

    public override string MenuDescription => "Reduces the HP of Elder Baldurs to 5.";

    #endregion

    #region Eventhandler

    private bool ModHooks_OnEnableEnemyHook(GameObject enemy, bool isAlreadyDead)
    {
        if (IsModuleUsed)
        {
            if (enemy.name == "Blocker")
            {
                HealthManager healthManager = enemy.GetComponent<HealthManager>();
                healthManager.hp = 5;
            }
        }

        return isAlreadyDead;
    }
    #endregion

    #region Methods

    internal override void Enable()
    {
        ModHooks.OnEnableEnemyHook += ModHooks_OnEnableEnemyHook;
    }

    internal override void Disable()
    {
        ModHooks.OnEnableEnemyHook -= ModHooks_OnEnableEnemyHook;
    }

    #endregion
}
