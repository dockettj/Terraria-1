﻿// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Dyes.LegacyHairShaderData
// Assembly: TerrariaServer, Version=1.3.5.3, Culture=neutral, PublicKeyToken=null
// MVID: 8A63A7A2-328D-424C-BC9D-BF23F93646F7
// Assembly location: H:\Steam\steamapps\common\Terraria\TerrariaServer.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
  public class LegacyHairShaderData : HairShaderData
  {
    private LegacyHairShaderData.ColorProcessingMethod _colorProcessor;

    public LegacyHairShaderData()
      : base((Ref<Effect>) null, (string) null)
    {
      this._shaderDisabled = true;
    }

    public override Color GetColor(Player player, Color lightColor)
    {
      bool lighting = true;
      Color color = this._colorProcessor(player, player.hairColor, ref lighting);
      if (lighting)
      {
        // ISSUE: explicit reference operation
        // ISSUE: explicit reference operation
        return new Color(Vector4.op_Multiply(((Color) @color).ToVector4(), ((Color) @lightColor).ToVector4()));
      }
      return color;
    }

    public LegacyHairShaderData UseLegacyMethod(LegacyHairShaderData.ColorProcessingMethod colorProcessor)
    {
      this._colorProcessor = colorProcessor;
      return this;
    }

    public delegate Color ColorProcessingMethod(Player player, Color color, ref bool lighting);
  }
}
