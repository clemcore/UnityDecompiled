﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.ProjectWindowCallback.DoCreatePrefab
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

namespace UnityEditor.ProjectWindowCallback
{
  internal class DoCreatePrefab : EndNameEditAction
  {
    public override void Action(int instanceId, string pathName, string resourceFile)
    {
      ProjectWindowUtil.ShowCreatedAsset(PrefabUtility.CreateEmptyPrefab(pathName));
    }
  }
}