﻿// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.ChatLine
// Assembly: TerrariaServer, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null
// MVID: 880A80AC-FC6C-4F43-ABDD-E2472DA66CB5
// Assembly location: F:\Steam\steamapps\common\Terraria\TerrariaServer.exe

using Microsoft.Xna.Framework;

namespace Terraria.UI.Chat
{
  public class ChatLine
  {
    public Color color = Color.get_White();
    public string text = "";
    public TextSnippet[] parsedText = new TextSnippet[0];
    public int showTime;
  }
}