// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Vehicle_ExperimentEditorTarget : TargetRules
{
	public Vehicle_ExperimentEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Vehicle_Experiment" } );
	}
}
