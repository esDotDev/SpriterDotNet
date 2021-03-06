﻿// Copyright (c) 2015 The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

using System;

namespace SpriterDotNet.MonoGame
{
#if WINDOWS || LINUX
    public static class Program
    {
        [STAThread]
        static void Main()
      {
            using (SpriteGame game = new SpriteGame())
            {
                game.Run();
            }
        }
    }
#endif
}
