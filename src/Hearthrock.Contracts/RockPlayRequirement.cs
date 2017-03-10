﻿// <copyright file="RockPlayRequirement.cs" company="https://github.com/yangyuan">
//     Copyright (c) The Hearthrock Project. All rights reserved.
// </copyright>

namespace Hearthrock.Contracts
{
    public enum RockPlayRequirement
    {
        None = 0,
        RequireMinionTarget = 1,
        RequireFriendlyTarget,
        RequireEnemyTarget,
        RequireDamagedTarget,
        RequireFrozenTarget = 6,
        RequireTargetMaxAttack = 8,
        RequireNonselfTarget,
        RequireTargetWithRace,
        RequireTargetToPlay,
        RequireNumMinionSlots,
        RequireWeaponEquipped,
        RequireHeroTarget = 17,
        RequireTargetIfAvailable = 22,
        RequireMiniumEnemyMinions,
        RequireTargetForCombo,
        RequireTargetMinAttack = 41,
        RequireEntireEntourageNotINPlay = 44,
        RequireMiniumTotalMinions,
        RequireMustTargetTaunter,
        RequireUndamagedTarget,
        RequireSteadyShot = 49,
        RequireMinionOrEnemyHero,
        RequireTargetIfAvailableAndDragonInHand,
        RequireLegendaryTarget,
        RequireFriendlyMinionDiedThisGame = 54,
        RequireEnemyWeaponEquipped,
        RequireTargetIfAvailableAndMiniumFriendlyMinions,
        RequireTargetWithDeathrattle = 58,
        RequireTargetIfAvailableAndMiniumFriendlySecrets,
        RequireSecretCapForNonSecret,
        RequireStealthedTarget = 62,
        RequireMinionSlotOrManaCrystalSlot,
    }
}