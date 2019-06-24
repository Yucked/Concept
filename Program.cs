﻿using Frostbyte.Handlers;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading.Tasks;
using System;

namespace Frostbyte
{
    public sealed class Program
    {
        public static Task Main()
        {
            Console.Title = "Frostbyte - Yucked";
            Console.WindowHeight = 25;
            Console.WindowWidth = 140;

            const string header = @"

        ▄████  █▄▄▄▄ ████▄    ▄▄▄▄▄      ▄▄▄▄▀ ███ ▀▄    ▄   ▄▄▄▄▀ ▄███▄   
        █▀   ▀ █  ▄▀ █   █   █     ▀▄ ▀▀▀ █    █  █  █  █ ▀▀▀ █    █▀   ▀  
        █▀▀    █▀▀▌  █   █ ▄  ▀▀▀▀▄       █    █ ▀ ▄  ▀█      █    ██▄▄    
        █      █  █  ▀████  ▀▄▄▄▄▀       █     █  ▄▀  █      █     █▄   ▄▀ 
         █       █                      ▀      ███  ▄▀      ▀      ▀███▀   
          ▀     ▀                                                          ";

            Console.WriteLine(header, Color.FromArgb(36, 231, 96));

            AppDomain.CurrentDomain.UnhandledException += (s, e)
                 => LogHandler<Program>.Log.Error(e.ExceptionObject as Exception);

            return new MainHandler().InitializeAsync();
        }
    }
}