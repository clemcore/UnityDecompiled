﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Experimental.UIElements.GraphView.SimpleElement
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

namespace UnityEditor.Experimental.UIElements.GraphView
{
  internal class SimpleElement : GraphElement
  {
    public SimpleElement()
    {
      this.text = "";
    }

    public override void OnDataChanged()
    {
      base.OnDataChanged();
      this.text = this.GetPresenter<SimpleElementPresenter>().title;
    }
  }
}