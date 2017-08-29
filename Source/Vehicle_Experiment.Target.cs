// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Vehicle_ExperimentTarget : TargetRules
{
	public Vehicle_ExperimentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Vehicle_Experiment" } );
	}
}
