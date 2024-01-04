// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class InsideSurvivorsRoguelikeEditorTarget : TargetRules
{
	public InsideSurvivorsRoguelikeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "InsideSurvivorsRoguelike" } );
	}
}
