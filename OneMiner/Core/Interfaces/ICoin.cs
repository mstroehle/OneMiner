﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneMiner.Core.Interfaces
{
    public class Pool
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public Pool(string name, string link)
        {
            Name = name;
            Link = link;
        }
    }
    public interface ICoin
    {
        /// <summary>
        /// nam of coin
        /// </summary>
        string Name { get;  }

        /// <summary>
        /// logo of the coin. this would be reqiired to show in thr ui
        /// </summary>
        Bitmap Logo { get; }

        /// <summary>
        /// Most coins would have its own way of setting the miner. if u have custom options u can provide 
        /// a custom ui to take the settings
        /// </summary>
        ICoinConfigurer SettingsScreen { get; }

        List<Pool> GetPools();

        /// <summary>
        /// The output of different miners would come i different formats
        /// This is the reader which can read output of this coin and provide us wioth data
        /// </summary>
        //IOutputReader OutputReader { get; }//Todo this might be neede to move as coins dont have readers. coins have miners(1 or more) which have readers

        IHashAlgorithm Algorithm { get; set; }


    }
}
