﻿using ItemLibraray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemBoxUI
{
    public interface IItemRequester
    {
        void ItemComplete(ItemModel model);
    }
}
