/*  HaRepacker Foothold Mapper - MapleStory Map + Foothold Renderer and Editor
 * Copyright (C) 2009, 2010  haha01haha01 and Odecey
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;

namespace Footholds
{
   public class FootHold
    {
        public struct Foothold
        {
            public Rectangle Shape;
            public WzSubProperty Data;
        }
    }
}
