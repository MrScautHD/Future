using System.Collections.Generic;
using FontStashSharp;
using Future.Client.csharp.renderer;
using Future.Client.csharp.ticker;
using Microsoft.Xna.Framework.Audio;

namespace Future.Client.csharp.registry; 

public class RegistryTypes {

    public static readonly Dictionary<string, IRenderer> Renderers = new();
    public static readonly Dictionary<string, FontSystem> Fonts = new();
    public static readonly Dictionary<string, SoundEffect> Sounds = new();
    public static readonly Dictionary<string, IClientTicker> Ticker = new();
}